using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    internal abstract class ParentTask
    {

        protected Random rndTimer = new Random();
        protected bool isRunning = true;

        public bool Running
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

    }
}
