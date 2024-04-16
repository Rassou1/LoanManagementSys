using LoanManagementSys.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    internal class ReturnTask : ParentTask
    {
        LoanManager lm;

        public ReturnTask(LoanManager lm)
        {
            this.lm = lm;
        }

        public void Run()
        {
            while(isRunning)
            {
                //Runs on associated thread.
                //Returns an item from the loanItems list back to the Products list.
                lm.Remove();
                Thread.Sleep(rndTimer.Next(5000, 15000));
            }
        }
    }
}
