using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1
{
    class ToDoList
    {
        private List<NoteWithTimeStamp> chores;

        public ToDoList()
        {
            chores = new List<NoteWithTimeStamp>();
        }

        public ToDoList(List<NoteWithTimeStamp> Chores)
        {
            this.chores = Chores;
        }

        public void addChore(NoteWithTimeStamp chore)
        {
            chores.Add(chore);
        }

        public void doChore(int indeks)
        {
            if (chores.Count > indeks)
            {
                chores.RemoveAt(indeks);
            }
        }

        public NoteWithTimeStamp getChore(int indeks)
        {
            int i = 0;

            foreach (NoteWithTimeStamp chore in chores)
            {
                if (i == indeks)
                {
                    return chore;
                }
                i++;
            }

            return null;
        }

        public void printToDoList()
        {
            foreach (NoteWithTimeStamp chore in chores)
            {
                Console.WriteLine(chore);
            }
        }
        public void doMostImportantChores()
        {
            int highestImportance = findHighestImportance();

            for(int i = chores.Count()-1; i >= 0; i--)
            {
                if(chores[i].Importance == highestImportance)
                {
                    chores.RemoveAt(i);
                }
            }
           
        }

        public int findHighestImportance()
        {
            int highestImportance, i;

            highestImportance = chores[0].Importance;

            for (i = 1; i < chores.Count(); i++)
            {
                if (highestImportance > chores[i].Importance)
                {
                    highestImportance = chores[i].Importance;
                }
            }

            return highestImportance;
        }


    }
}
