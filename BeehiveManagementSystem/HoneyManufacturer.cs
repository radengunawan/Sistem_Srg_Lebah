using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;

        // While in the base class:

        //public abstract float CostPerShift { get; } 
        public override float CostPerShift { get { return 1.7f; } }

        /* While in the base class:
         * 
         * public Bee(string job){
         *          this.Job = job;  }       */
        public HoneyManufacturer() : base("Honey Manufacturer") { }

         /*  While in the base class:
          *  
         *  protected abstract void DoJob();*/
        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    } //END class
}
