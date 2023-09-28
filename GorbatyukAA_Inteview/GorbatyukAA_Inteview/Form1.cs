using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorbatyukAA_Inteview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeProcessThread();         
            Process[] initialProcesses = Process.GetProcesses();
            UpdateProcessListStart(initialProcesses);
        }
        public int counts = 0;
        private Thread processThread;
        static bool isRunning = true;
        private Thread processThreadInf;
        static bool isRunningInf = true;
        private bool isPaused = false;
        static PerformanceCounter memoryCounter;
        static PerformanceCounter cpuCounter;

        private void InitializeProcessThread()
        {
            processThread = new Thread(() =>
            {
                while (isRunning)
                {
                    if (!isPaused)
                    {
                        Process[] newProcesses = Process.GetProcesses();

                        UpdateProcessList(newProcesses);
                        if (lbTimeNow.IsHandleCreated)
                        {
                            lbTimeNow.Invoke(new Action(() =>
                            {
                                lbTimeNow.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            }));
                        }
                        
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }
            });

            processThread.Start();
        }


        void UpdateProcessList(Process[] newProcesses)
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() => UpdateProcessList(newProcesses)));
            }
            else
            {
                int visibleRowCount = dataGridView1.DisplayedRowCount(false); 
                int totalRowCount = newProcesses.Length;

                vScrollBar1.Minimum = 0;
                vScrollBar1.Maximum = Math.Max(0, totalRowCount - visibleRowCount);
                vScrollBar1.LargeChange = visibleRowCount;
                vScrollBar1.SmallChange = 1; 

                dataGridView1.Rows.Clear();

                for (int i = vScrollBar1.Value; i < Math.Min(totalRowCount, vScrollBar1.Value + visibleRowCount); i++)
                {
                    dataGridView1.Rows.Add(newProcesses[i].ProcessName, newProcesses[i].Id.ToString());
                }
            }
            gradientText1.Text = newProcesses.Length.ToString();
        }

        void UpdateProcessListStart(Process[] newProcesses)
        {
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() => UpdateProcessList(newProcesses)));
            }
            else
            {
                int visibleRowCount = dataGridView1.DisplayedRowCount(false); 
                int totalRowCount = newProcesses.Length;

                vScrollBar1.Minimum = 0;
                vScrollBar1.Maximum = Math.Max(0, totalRowCount - visibleRowCount);
                vScrollBar1.LargeChange = visibleRowCount;
                vScrollBar1.SmallChange = 1;

                dataGridView1.Rows.Clear();

                foreach (Process process in newProcesses)
                {
                    ProcessAnalyst p = new ProcessAnalyst(process.ProcessName, process.Id);
                    dataGridView1.Rows.Add(process.ProcessName, process.Id.ToString());
                }
            }
            gradientText1.Text = newProcesses.Length.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            isRunning = false;
            processThread.Join();
            this.Close();
        }

        int mouseX = 0;
        int mouseY = 0;
        bool mousePressed;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePressed = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counts++;
        }

        private void SortMember_Click(object sender, EventArgs e)
        {
            string filePath = "log.txt";

            try
            {
                if (System.IO.File.Exists(filePath))
                {                   
                    Process.Start("log.txt", filePath);
                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Process[] newProcesses = Process.GetProcesses();
            UpdateProcessList(newProcesses);
        }


        static string GetProcessNameById(int processId)
        {
            Process process = Process.GetProcessById(processId);
            return process.ProcessName;
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IDProcessInf = int.Parse(dataGridView1[e.ColumnIndex+1, e.RowIndex].Value.ToString());
            Process process = Process.GetProcessById(IDProcessInf);
            if (process != null)
            {
                memoryCounter = new PerformanceCounter("Process", "Working Set", GetProcessNameById(IDProcessInf));
                cpuCounter = new PerformanceCounter("Process", "% Processor Time", GetProcessNameById(IDProcessInf));
                lbNameProcess.Text = process.ProcessName;
                lbIDProcess.Text=process.Id.ToString();
                lbNameWindowsProcess.Text = process.MainWindowTitle;

                processThreadInf = new Thread(() =>
                {
                    while (isRunningInf)
                    {   
                        float memoryUsage = memoryCounter.NextValue() / (1024 * 1024); 
                        float cpuUsage = cpuCounter.NextValue();

                        lbMemberProcess.Invoke(new Action(() =>
                        {
                            lbMemberProcess.Text = memoryUsage.ToString("0.00") + " MB";
                        }));

                        lbCPProcess.Invoke(new Action(() =>
                        {
                            lbCPProcess.Text =cpuUsage.ToString("0.00") + " %";
                        }));

                        Thread.Sleep(1000);         
                    }
                });
                processThreadInf.Start();
                LogMessage(string.Format("Получена информация о процессе: {0}", process.ProcessName));

            }
            else
            {
                MessageBox.Show("Процесс не найден.");
                LogMessage(string.Format($"Процесс {process.ProcessName} запрошен, но не найдет")); ;
            }           
        }

        private void btCloseInfProcess_Click(object sender, EventArgs e)
        {
            isRunningInf = false;
            processThreadInf.Join();
            lbNameProcess.Text = "";
            lbNameWindowsProcess.Text = "";
            lbIDProcess.Text = "";
            lbMemberProcess.Text = "";
            lbCPProcess.Text = "";
        }

        private void btProcessStopPlay_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (btProcessStopPlay.Text== "Приостановить обновление")
            {
                btProcessStopPlay.Text = "Продолжить обновление";
            }
            else
            {
                btProcessStopPlay.Text = "Приостановить обновление";
            }
            LogMessage(isPaused ? "Приостановка обновления списка процессов" : "Продолжение обновления списка процессов");

        }

        private void LogMessage(string message)
        {
            string logFilePath = "log.txt";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine("{0} - {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), message);
            }
        }

    }
}
