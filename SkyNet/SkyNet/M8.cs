using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class M8:MechanicalOperator
    {
        private float loadCapacity;
        private float appendageType;

        public float LoadCapacity { get; set; }
        public float AppendageType { get; set; }

        public M8()
        {
            this.loadCapacity = 0;
            this.appendageType = 0;
        }

        public void Reconnoiter()
        {

        }
    }
}
