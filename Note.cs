using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1
{
    class Note
    {
        protected string text;
        protected string author;
        protected int importance;


        public string getText() { return this.text; }
        public string getAuthor() { return this.author; }

        public int getImportance() { return this.importance; }

        public void setText(string Text) { this.text = Text; }
        public void setImportance(int Importance) { this.importance = Importance; }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public int Importance
        {
            get { return this.importance; }
            set { this.importance = value; }
        }

        public string Author
        {
            get { return this.author; }
        }

        public Note()
        {
            this.text = "-";
            this.author = "Anonymus";
            this.importance = 1;
        }

        public Note(string Text, string Author, int Importance)
        {
            this.text = Text;
            this.author = Author;
            this.importance = Importance;
        }
        public Note(Note original)
        {
            this.text = original.text;
            this.author = original.author;
            this.importance = original.importance;
        }

        public Note(string Text, string Author)
        {
            this.text = Text;
            this.author = Author;
            this.importance = 1;
        }

        public override string ToString()
        {
            return this.author + ": " + this.text;
        }
    }
}
