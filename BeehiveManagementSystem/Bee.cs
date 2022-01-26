using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    abstract class Bee
    {
        public string Job { get; private set; }
        public abstract float CostPerShift { get; }
        

        public Bee(string job) 
        {
            this.Job = job;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();
    }

}
