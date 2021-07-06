using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCarsRacing
{
   public class runer
    {
        public int mve() {
            Random rd = new Random();
            return rd.Next(1, 40);
        }

        public int stp() {
            return 900;
        }
    }
}
