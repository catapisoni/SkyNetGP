using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public class HeadQuarters
    {
        private List<MechanicalOperator> operators;

        public List<MechanicalOperator> Operators { get; set; }

        public HeadQuarters()
        {
            this.operators = new List<MechanicalOperator>();
        }

        public void ShowOperatorStatus()
        {

        }
        public void ShowOperatorStatusAtLocation(string loc)
        {

        }
        public void TotalRecall()
        {

        }

        /* public MechanicalOperator SelectOperator(string id)
         {
             return ;
         }*/

        public void AddReserveOperator(MechanicalOperator op)
        {

        }
        public void RemoveReserveOperator(MechanicalOperator op)
        {

        }


    }
}
