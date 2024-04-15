using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSys.Tasks
{
    internal class AdminTask : ParentTask
    {
        ProductManager pm;

        public AdminTask(ProductManager pm)
        {
            this.pm = pm;
        } 

        public void Run()
        {
            while (isRunning)
            {
                //Runs on associated thread.
                //Adds a randomized product every 5-15 seconds.
                pm.AddNewTestProduct();
                Thread.Sleep(rndTimer.Next(5000, 15000));
            }
        }
    }
}
