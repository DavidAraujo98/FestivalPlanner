using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanFest
{
    [Serializable()]

    internal class Festival
    {
        public string name { get; set; }
        public string dateEnd { get; set; }
        public string dateBegin { get; set; }
        public string id { get; set; }
        public int nDays { get; set; }
        public int nTickets { get; set; }
        public Promoter promoter { get; set; }
        public Manager manager { get; set; }
        public List<Meal> meals { get; set; }
        public List<Stage> stages { get; set; }

        public void addStage(Stage e)
        {
            stages.Add(e);
        }

        public void addMeal(Meal e)
        {
            meals.Add(e);
        }

        public Festival(string name="", string dateEnd="", string dateBegin="", string id="", int ndays=0, int ntickets=0, Promoter promoter=null, Manager manager=null, List<Meal> meals=null, List<Stage> stages=null) : base()
        {
            this.name = name;
            this.dateEnd = dateEnd;
            this.dateBegin = dateBegin;
            this.id = id;
            this.nDays = ndays;
            this.nTickets = ntickets;
            this.promoter = promoter;
            this.manager = manager;
            this.meals = meals;
            this.stages = stages;
        }
    }
}
