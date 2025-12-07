using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_and_LibraryCard
{
    public class LibraryCard
    {
        private string cardNumber;
        private DateTime issueDate;
        private bool isActive;

        public string CardNumber
        {
            get { return this.cardNumber; }
            set { this.cardNumber = value; }
        }
        public DateTime IssueDate
        {
            get { return this.issueDate; }
            set { this.issueDate = value; }
        }
        public bool IsActive
        {
            get { return this.isActive; }
            set { isActive = value; }
        }
        public LibraryCard()
        {
            CardNumber = "Unknown";
            IssueDate = DateTime.Now;
            IsActive = false;

        }
        public LibraryCard(string cardNumber,DateTime issueDate, bool isActive)
        {

            this.cardNumber = cardNumber;
            this.issueDate = issueDate;
            this.isActive = isActive;
        }
        public void ShowDetails()
        {

            Console.WriteLine("  ");
            Console.WriteLine("Library Card Info: ");
            Console.WriteLine("Issue Date: " + this.issueDate);
            Console.WriteLine("Is Active: " + this.isActive);
        }
    }
}
