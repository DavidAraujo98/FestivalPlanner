using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Meal
    {
        public  int id { get; private set; }
        public string mainDish { get; set; }
        public string dessert { get; set; }
        public string drink { get; set; }
        public Company cathering { get; set; }

        public Meal(int id=0, string mainDish="", string dessert="", string drink="", Company cathering=null) : base()
        {
            this.id = id;
            this.mainDish = mainDish;
            this.dessert = dessert;
            this.drink = drink;
            this.cathering = cathering;
        }
    }
}
