using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    class EggCare : Bee
    {
        public const float CARE_PROGRESS_PER_SHIFT = 0.15f;

        /*
         *  public abstract float CostPerShift { get; }
         */
        public override float CostPerShift { get { return 1.35f; } }

        private Queen queen;


        /*
         * public Bee(string job) 
         *   {
         *       this.Job = job;
         *       }
         */
        public EggCare(Queen queen) : base("Egg Care")
        {
            this.queen = queen;
        }


        /*
         *    protected abstract void DoJob();
         */
        protected override void DoJob()
        {
            queen.CareForEggs(CARE_PROGRESS_PER_SHIFT);
        }
    }
}
