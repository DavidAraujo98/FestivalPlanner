using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Instrument
    {
        public int id { get; private set; }
        public string brand { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public string family { get; set; }

        public Musician owner { get; set; }

        public Instrument(int id=0, string brand="", string maker="", string model="", string family="", Musician owner=null)
        {
            this.id = id;
            this.brand = brand;
            this.maker = maker;
            this.model = model;
            this.family = family;
            this.owner = owner;
        }
    }
}
