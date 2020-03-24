using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numberOfChores = 3, importance;
            Note firstNote, secodNote, thirdNote;
            NoteWithTimeStamp fourthNote;
            ToDoList chores = new ToDoList();
            string text, name;

            

            firstNote = new Note();
            secodNote = new Note("Massage", "Luka", 1);
            thirdNote = new Note("Another masage","Filip");
            fourthNote = new NoteWithTimeStamp("Jet another massage", "Marko", 1);
        

            Console.WriteLine(firstNote.Author + ": " + firstNote.Text);
            Console.WriteLine(secodNote.ToString());
            Console.WriteLine(thirdNote);
            Console.WriteLine(fourthNote);

            Console.WriteLine("Koliko zabiljeski zelite? ");
            numberOfChores = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < numberOfChores; i++)
            {
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();
                Console.WriteLine("What is your chore? ");
                text = Console.ReadLine();
                Console.WriteLine("How important is your chore?");
                importance = Convert.ToInt32(Console.ReadLine());

                chores.addChore(new NoteWithTimeStamp(text, name, importance));
            }

            chores.printToDoList();
            chores.doMostImportantChores();
            chores.printToDoList();

        }
    }
}
