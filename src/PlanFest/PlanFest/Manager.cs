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
        public string type { get; set; }
        public Festival festival { get; set; }
        public string dateBegin { get; set; }
        public string dateEnd { get; set; }

        public Manager (string nCC = "", string telephone = "", string name = "", string sex = "", string email = "", string type="", Festival festival=null,string dateBegin="", string dateEnd="") : base(nCC, telephone, name, sex, email)
        { 
            this.type = type;
            this.festival = festival;
            this.dateBegin = dateBegin;
            this.dateEnd = dateEnd;
        }
    }
}
