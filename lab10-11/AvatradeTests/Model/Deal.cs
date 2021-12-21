using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Model
{
    class Deal
    {
        double stopLoss = 0;
        double takePofit = 0;

        public Deal(double stopLoss, double takePofit)
        {
            this.stopLoss = stopLoss;
            this.takePofit = takePofit;
        }

        public double StopLoss
        {
            set => stopLoss = value;
            get => stopLoss;
        }
        public double TakePofit
        {
            set => takePofit = value;
            get => takePofit;
        }

        public override string ToString()
        {
            return takePofit.ToString() + " " + stopLoss.ToString();
        }
    }
}
