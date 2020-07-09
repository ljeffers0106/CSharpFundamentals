using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManChallenge
{
    public enum Birds
    {
        Bird = 1,
        CrestedIbis,
        GreatKiskudee,
        RedCrossbill,
        RedneckedPhalarope, 
        EveningGrosbeak,
        GreaterPrairieChicken,
        IcelandGull,
        OrangeBelliedParrot,
    }
     

    public class Drofsnar
    {
        // properties
        public int Points { get; set; }
        public int Lives { get; set; }
        

        public Drofsnar() { }
        public Drofsnar(int points, int lives)
        {
            Points = points;
            Lives = lives;
        }
        

    }
    
}
