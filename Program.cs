using System;
namespace SealedClass
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    } //end interface
    class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }//end Employee
    sealed class Executive : Employee
    {
        public double Salary { get; set; }
        public string Title { get; set; }
        public Executive() : base()
        {
            Salary = 0;
            Title = string.Empty;
        }
        public Executive (int id, string firstname, string lastname, double salary, string title) : base(id, firstname, lastname)
        {
            Salary = salary;
            Title = title;
        }

        public override double Pay()
        {
            if (Title == "CEO")
                return Salary = 800000;
            else
                return Salary = 400000;
        }
    } //end executive
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee object: ");
            //employee object
            Employee employee = new Employee(10, "Mary", "Poppins");
            Console.WriteLine($"Full name: {employee.Fullname()} \nId number: {employee.Id} \nSalary information: {employee.Pay()}");
            
            Console.WriteLine();
            Console.WriteLine("Executive object: ");
            //executive object
            Executive executive = new Executive(30, "Tina", "Fey", 50000, "CEO");
            Console.WriteLine($"Full name: {executive.Fullname()} \nId number: {executive.Id} \nTitle: {executive.Title} \nSalary information: {executive.Pay()}");

        }//end main
    }//end program
}//end namespace