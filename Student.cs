using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_LibraryCard
{
    public class Student
    {
        private int studentID;
        private string name;
        private LibraryCard libraryCard;

        public int StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public LibraryCard LibraryCard
        {
            get { return this.libraryCard; }
            set { this.libraryCard = value; }
        }
        public Student()
        {

        }
        public Student(int studentID, string name, LibraryCard libraryCard
            )
        {

            this.studentID = studentID;
            this.name = name;
            this.libraryCard = libraryCard;
        }
        public void ActivateLibraryCard()
        {
            this.libraryCard.IsActive = true;
        }


        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Student ID: " + this.studentID);
            Console.WriteLine("Name: " + this.name);
            this.libraryCard.ShowDetails();
        }
    }
}
