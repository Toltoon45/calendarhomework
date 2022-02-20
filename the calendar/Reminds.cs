using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_calendar
{
    [Serializable]
    class Reminds
    {
        public List<Reminds> RemindList { get; set; } = new List<Reminds>();
    }

    [Serializable]
    //Наследуемый от "праздник" класс "напоминание"
    public class Remind : Celebration
    {
        public string Celeb_date_end { get; set; }
        public Remind(string date, string date_end, string name)
                    :base(date,date_end, name)
        {
            this.date_end = date_end;
        }



        public Remind() { }
        //Переопределение для корректной записи "напоминание"
        public override string ToString()
        {
            return $"{date} - {date_end} {name}";
        }
    }
}
