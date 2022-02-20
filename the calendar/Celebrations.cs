using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_calendar
{
    [Serializable]
    class Celebrations
    {
        public List<Celebrations> CelebList { get; set; } = new List<Celebrations>();
    }

    [Serializable]
    public class Celebration
    {
        //Начальная дата, название даты, конечная дата
        public string date { get; set; }
        public string name { get; set; }
        public string date_end { get; set; }



        public Celebration(string date, string name)
        {
            this.date = date;
            this.name = name;
        }

        public Celebration() { }

        public Celebration(string date, string name, string date_end)
        {
            this.date = date;
            this.name = name;
            this.date_end = date_end;
        }

        public override string ToString()
        {
            return $"{date} {name}";
        }
    }


}
