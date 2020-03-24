using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1
{
    class NoteWithTimeStamp : Note
    {
        private DateTime time;

        public NoteWithTimeStamp(string Text, string Author, int Importance) : base(Text, Author, Importance)
        {
            this.time = DateTime.Now;
        }

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " (" +  time + ")";
        }
    }
}
