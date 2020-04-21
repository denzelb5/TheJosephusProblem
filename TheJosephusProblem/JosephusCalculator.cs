using System;
using System.Collections.Generic;
using System.Text;

namespace TheJosephusProblem
{
    public class JosephusCalculator
    {
        public int LastManStanding(int numberOfPeeps, int killingInterval)
        {
            
            if (numberOfPeeps == 1)
            {
              return 1;
            }
            else 
            { 
              return (LastManStanding(numberOfPeeps - 1, killingInterval) + killingInterval - 1) % numberOfPeeps + 1;
            }
        }
    }
}
