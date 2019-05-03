using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBCC_WMAD_Console
{
    public class Car
    {
        private int? speed;//?means it is nullable.
        private Nullable<decimal> price;//same as decimal?
        private int numberOfDoors;
        private string carType;
        
        public int? Year { get; set; }//auto properties also work with nullable

        public int? Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public decimal? Price
        {
            get { return price; }
            set { price = value; }
        }

        public int NumberOfDoors
        { get { return numberOfDoors; }
            set {
                //ensure the value of 10
                if (value < 10)
                {
                    numberOfDoors = value;
                }
            }
        }
        public string CarType { get; set; }
        
    }

}
