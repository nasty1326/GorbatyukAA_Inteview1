namespace GorbatyukAA_Inteview
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gradient1 = new GorbatyukAA_Inteview.Gradient();
            this.lbTimeNow = new System.Windows.Forms.Label();
            this.btProcessStopPlay = new System.Windows.Forms.Button();
            this.btCloseInfProcess = new System.Windows.Forms.Button();
            this.gradient2 = new GorbatyukAA_Inteview.Gradient();
            this.lbIDProcess = new GorbatyukAA_Inteview.GradientText();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCPProcess = new GorbatyukAA_Inteview.GradientText();
            this.lbMemberProcess = new GorbatyukAA_Inteview.GradientText();
            this.lbNameWindowsProcess = new GorbatyukAA_Inteview.GradientText();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNameProcess = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SortMember = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientText1 = new GorbatyukAA_Inteview.GradientText();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.gradient2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBot = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.gradient1.Controls.Add(this.lbTimeNow);
            this.gradient1.Controls.Add(this.btProcessStopPlay);
            this.gradient1.Controls.Add(this.btCloseInfProcess);
            this.gradient1.Controls.Add(this.gradient2);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.vScrollBar1);
            this.gradient1.Controls.Add(this.panel3);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Controls.Add(this.gradientText1);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Margin = new System.Windows.Forms.Padding(4);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(992, 565);
            this.gradient1.TabIndex = 0;
            // 
            // lbTimeNow
            // 
            this.lbTimeNow.AutoSize = true;
            this.lbTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeNow.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.lbTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbTimeNow.Location = new System.Drawing.Point(335, 524);
            this.lbTimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeNow.Name = "lbTimeNow";
            this.lbTimeNow.Size = new System.Drawing.Size(0, 24);
            this.lbTimeNow.TabIndex = 14;
            // 
            // btProcessStopPlay
            // 
            this.btProcessStopPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.btProcessStopPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btProcessStopPlay.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btProcessStopPlay.ForeColor = System.Drawing.Color.White;
            this.btProcessStopPlay.Location = new System.Drawing.Point(77, 519);
            this.btProcessStopPlay.Name = "btProcessStopPlay";
            this.btProcessStopPlay.Size = new System.Drawing.Size(251, 33);
            this.btProcessStopPlay.TabIndex = 13;
            this.btProcessStopPlay.Text = "Приостановить обновление";
            this.btProcessStopPlay.UseVisualStyleBackColor = false;
            this.btProcessStopPlay.Click += new System.EventHandler(this.btProcessStopPlay_Click);
            // 
            // btCloseInfProcess
            // 
            this.btCloseInfProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.btCloseInfProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCloseInfProcess.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCloseInfProcess.ForeColor = System.Drawing.Color.White;
            this.btCloseInfProcess.Location = new System.Drawing.Point(578, 388);
            this.btCloseInfProcess.Name = "btCloseInfProcess";
            this.btCloseInfProcess.Size = new System.Drawing.Size(278, 33);
            this.btCloseInfProcess.TabIndex = 12;
            this.btCloseInfProcess.Text = "Закрыть информациб о процессе";
            this.btCloseInfProcess.UseVisualStyleBackColor = false;
            this.btCloseInfProcess.Click += new System.EventHandler(this.btCloseInfProcess_Click);
            // 
            // gradient2
            // 
            this.gradient2.ColorBot = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(46)))));
            this.gradient2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.gradient2.Controls.Add(this.lbIDProcess);
            this.gradient2.Controls.Add(this.label8);
            this.gradient2.Controls.Add(this.lbCPProcess);
            this.gradient2.Controls.Add(this.lbMemberProcess);
            this.gradient2.Controls.Add(this.lbNameWindowsProcess);
            this.gradient2.Controls.Add(this.label7);
            this.gradient2.Controls.Add(this.label6);
            this.gradient2.Controls.Add(this.label5);
            this.gradient2.Controls.Add(this.lbNameProcess);
            this.gradient2.Location = new System.Drawing.Point(574, 56);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(400, 315);
            this.gradient2.TabIndex = 11;
            // 
            // lbIDProcess
            // 
            this.lbIDProcess.AutoSize = true;
            this.lbIDProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbIDProcess.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbIDProcess.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.lbIDProcess.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIDProcess.Location = new System.Drawing.Point(255, 148);
            this.lbIDProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDProcess.Name = "lbIDProcess";
            this.lbIDProcess.Size = new System.Drawing.Size(0, 23);
            this.lbIDProcess.TabIndex = 16;
            this.lbIDProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(13, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Идентификатор процесса:";
            // 
            // lbCPProcess
            // 
            this.lbCPProcess.AutoSize = true;
            this.lbCPProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbCPProcess.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbCPProcess.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.lbCPProcess.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCPProcess.Location = new System.Drawing.Point(312, 272);
            this.lbCPProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCPProcess.Name = "lbCPProcess";
            this.lbCPProcess.Size = new System.Drawing.Size(0, 23);
            this.lbCPProcess.TabIndex = 14;
            this.lbCPProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMemberProcess
            // 
            this.lbMemberProcess.AutoSize = true;
            this.lbMemberProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbMemberProcess.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbMemberProcess.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.lbMemberProcess.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMemberProcess.Location = new System.Drawing.Point(222, 210);
            this.lbMemberProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMemberProcess.Name = "lbMemberProcess";
            this.lbMemberProcess.Size = new System.Drawing.Size(0, 23);
            this.lbMemberProcess.TabIndex = 13;
            this.lbMemberProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNameWindowsProcess
            // 
            this.lbNameWindowsProcess.AutoSize = true;
            this.lbNameWindowsProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbNameWindowsProcess.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbNameWindowsProcess.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.lbNameWindowsProcess.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameWindowsProcess.Location = new System.Drawing.Point(13, 101);
            this.lbNameWindowsProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameWindowsProcess.Name = "lbNameWindowsProcess";
            this.lbNameWindowsProcess.Size = new System.Drawing.Size(0, 18);
            this.lbNameWindowsProcess.TabIndex = 12;
            this.lbNameWindowsProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Общее использование процессора:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(11, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Используемая память:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Заголовок главного окна процесса:";
            // 
            // lbNameProcess
            // 
            this.lbNameProcess.AutoSize = true;
            this.lbNameProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbNameProcess.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.lbNameProcess.Location = new System.Drawing.Point(10, 22);
            this.lbNameProcess.Name = "lbNameProcess";
            this.lbNameProcess.Size = new System.Drawing.Size(0, 24);
            this.lbNameProcess.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IDProcess});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            this.dataGridView1.Location = new System.Drawing.Point(77, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(409, 448);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // IDProcess
            // 
            this.IDProcess.HeaderText = "ID";
            this.IDProcess.MinimumWidth = 6;
            this.IDProcess.Name = "IDProcess";
            this.IDProcess.ReadOnly = true;
            this.IDProcess.Visible = false;
            this.IDProcess.Width = 125;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(489, 56);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(25, 448);
            this.vScrollBar1.TabIndex = 9;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.SortMember);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 565);
            this.panel3.TabIndex = 7;
            // 
            // SortMember
            // 
            this.SortMember.Image = ((System.Drawing.Image)(resources.GetObject("SortMember.Image")));
            this.SortMember.Location = new System.Drawing.Point(13, 270);
            this.SortMember.Margin = new System.Windows.Forms.Padding(4);
            this.SortMember.Name = "SortMember";
            this.SortMember.Size = new System.Drawing.Size(32, 32);
            this.SortMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SortMember.TabIndex = 0;
            this.SortMember.TabStop = false;
            this.SortMember.Click += new System.EventHandler(this.SortMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 48);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(900, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(943, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gradientText1
            // 
            this.gradientText1.AutoSize = true;
            this.gradientText1.BackColor = System.Drawing.Color.Transparent;
            this.gradientText1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.gradientText1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.gradientText1.Font = new System.Drawing.Font("Century Gothic", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradientText1.Location = new System.Drawing.Point(768, 429);
            this.gradientText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradientText1.Name = "gradientText1";
            this.gradientText1.Size = new System.Drawing.Size(220, 123);
            this.gradientText1.TabIndex = 2;
            this.gradientText1.Text = "305";
            this.gradientText1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(72)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(546, 483);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВСЕГО ПРОЦЕССОВ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 565);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.gradient2.ResumeLayout(false);
            this.gradient2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SortMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Label label1;
        private GradientText gradientText1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox SortMember;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gradient gradient2;
        private GradientText lbCPProcess;
        private GradientText lbMemberProcess;
        private GradientText lbNameWindowsProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNameProcess;
        private System.Windows.Forms.Button btCloseInfProcess;
        private GradientText lbIDProcess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTimeNow;
        private System.Windows.Forms.Button btProcessStopPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProcess;
        private System.Windows.Forms.Label label5;
    }
}

