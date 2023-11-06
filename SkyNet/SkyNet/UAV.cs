using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class UAV:MechanicalOperator
    {
        private float flightHeight;
        private int bladeAmount;
        private bool integratedCamera;

        public float FlightHeight { get; set; }
        public int BladeAmount { get; set; }
        public bool IntegratedCamera { get; set; }
        public UAV()
        {
            this.flightHeight = 0;
            this.bladeAmount = 0;
            this.integratedCamera = false;
        }

        public void Fly()
        {

        }
    }
}
