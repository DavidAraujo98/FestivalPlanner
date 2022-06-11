using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class SoundCheck
    {
        public int id { get; set;}
        private string dateBegin { get; set; }

        private Concert concert { get; set; }

        public SoundCheck(int id=0, string dateBegin="", Concert concert=null) : base()
        {
            this.id = id;
            this.dateBegin = dateBegin;
            this.concert = concert;
        }
    }
}
