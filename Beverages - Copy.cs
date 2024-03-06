using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{


    enum Roast
    {
        Dark,
        Medium,
        Light,

    }
    enum CupSize
    {
        Small,
        Medium,
        Large,
    }
    enum Temperature
    {
        Iced,
        Hot,
    }
    enum Sugar
    {
        No,
        Yes,
        X2,
        X3,
        X4,
    }
    enum Creamer
    {
        No,
        Yes,
        X2,
        X3,
        X4,
    }



    abstract class Beverage
    {

        public string CustomerName { get; set; }

        public CupSize CupSize { get; set; }

        public Temperature Temperature { get; set; }

        public String Time { get; set; }
    }

    class Coffee : Beverage
    {
        public Roast Roast { get; set; }
        public Sugar Sugar { get; set; }
        public Creamer Creamer { get; set; }
    }

    
        
}















