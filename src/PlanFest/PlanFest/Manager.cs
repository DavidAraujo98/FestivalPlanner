using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]
    internal class Manager : Person
    {
        public String type { get; set; }
        public Festival festival { get; set; }
        public String dateBegin { get; set; }
        public String dateEnd { get; set; }

        public Manager (int nCC = 0, int telephone = 0, string name = "", string sex = "", string email = "", string type="", Festival festival=null,string dateBegin="", string dateEnd="") : base(nCC, telephone, name, sex, email)
        { 
            this.type = type;
            this.festival = festival;
            this.dateBegin = dateBegin;
            this.dateEnd = dateEnd;
        }
    }
}
