namespace QuestionNo9
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
    public class Manager : Employee
{
    private double bonus;


    public Manager() : base()
    {
        this.Designation = "Manager"; 
    }

 
    public Manager(double salary, string dept, double bonus)
        : base(salary, "Manager", dept)
    {
        this.bonus = bonus;
    }

        public Manager(int v1, DepartmentType iT, int v2)
        {
            V1 = v1;
            IT = iT;
            V2 = v2;
        }

       
        public double Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

        public int V1 { get; }
        public DepartmentType IT { get; }
        public int V2 { get; }

       
        public new void Accept()
    {
        base.Accept(); 

        Console.Write("Enter bonus: ");
        this.Bonus = Convert.ToDouble(Console.ReadLine());
    }

  
    public new void Print()
    {
        Console.WriteLine(this.ToString());
    }

    
    public override string ToString()
    {
        return $"{base.ToString()}, Bonus: {this.Bonus}";
    }
}
    public class Employee : Person
    {
        private static int count = 0; 
        private int id;
        private double salary;
        private string designation;
        private string dept;

       
        public Employee()
        {
            this.id = ++count;
        }

       
        public Employee(double salary, string designation, string dept)
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

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        
        public void Accept()
        {
            Console.Write("Enter salary: ");
            this.Salary = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("Enter department (HR, IT, Sales, Finance, Marketing): ");
            
        }

       
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        
        public override string ToString()
        {
            return $"ID: {this.Id}, Salary: {this.Salary}, Designation: {this.Designation}, Department: {this.Dept}";
        }
        public static void Main()
    {
        
        Manager mgr1 = new Manager();
        mgr1.Accept();
        mgr1.Print();

       
        Manager mgr2 = new Manager(80000, DepartmentType.IT, 5000);
        mgr2.Print();
    }
    }
}

