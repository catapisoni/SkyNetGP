using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class K9 : MechanicalOperator
    {
        private string sensorType;
        private string movility;

        public string SensorType { get; set; }
        public string Movility { get; set; }
        public K9()
        {
            this.sensorType = string.Empty;
            this.movility = string.Empty;
        }

        public void Patrol()
        {

        }
    }
}
