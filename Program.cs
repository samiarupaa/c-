using System;


namespace Student_and_LibraryCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LibraryCard l1 = new LibraryCard("LC12345", DateTime.Now, false);

          
            Student student = new Student(0001, "Samia Akter Rupa", l1);
            student.ActivateLibraryCard();
            student.ShowDetails();
        }
    }
}
