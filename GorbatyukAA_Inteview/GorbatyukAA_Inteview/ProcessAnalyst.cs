using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorbatyukAA_Inteview
{
    internal class ProcessAnalyst
    {
        private string processName;
        private int processID;
        private bool have = false;

        public ProcessAnalyst (string _processName, int _processID)
        {
            this.processName = _processName;
            this.processID = _processID;
        }
        public void HaveProcess()
        {
            this.have = true;
        }
        public string GetProcessName()
        {
            return this.processName;
        }
        public int GetProcessID()
        {
            return this.processID;
        }

        public bool GetHave()
        {
            return this.have;
        }
    }
}
