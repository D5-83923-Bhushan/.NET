namespace QuestionNo10
{
    public class Person
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public enum DepartmentType
    {
        HR,
        IT,
        Sales,
        Finance,
        Marketing
    }

    public class Employee : Person
    {
        private static int count = 0; 
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public Employee()
        {
            this.id = ++count;
        }

        public Employee(double salary, string designation, DepartmentType dept)
            : this() 
        {
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
        }

        
        public int Id
        {
            get { return id; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

       
        public void Accept()
        {
            Console.Write("Enter salary: ");
            this.Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter designation: ");
            this.Designation = Console.ReadLine();

            Console.Write("Enter department (HR, IT, Sales, Finance, Marketing): ");
            this.Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), Console.ReadLine(), true);
        }

     
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

       
        public override string ToString()
        {
            return $"ID: {this.Id}, Salary: {this.Salary}, Designation: {this.Designation}, Department: {this.Dept}";
        }
    }


    public class Supervisor : Employee
    {
        private int subordinates;

    
        public Supervisor() : base()
        {
        }

   
        public Supervisor(double salary, string designation, DepartmentType dept, int subordinates)
            : base(salary, designation, dept)
        {
            this.subordinates = subordinates;
        }

        public int Subordinates
        {
            get { return subordinates; }
            set { subordinates = value; }
        }

     
        public new void Accept()
        {
            base.Accept(); 

            Console.Write("Enter number of subordinates: ");
            this.Subordinates = Convert.ToInt32(Console.ReadLine());
        }

     
        public new void Print()
        {
            Console.WriteLine(this.ToString());
        }

       
        public override string ToString()
        {
            return $"{base.ToString()}, Subordinates: {this.Subordinates}";
        }
        public class Program
        {
            public static void Main()
            {
                
                Supervisor sup1 = new Supervisor();
                sup1.Accept();
                sup1.Print();

                Supervisor sup2 = new Supervisor(75000, "Team Lead", DepartmentType.Sales, 5);
                sup2.Print();
            }
        }

    }

}
