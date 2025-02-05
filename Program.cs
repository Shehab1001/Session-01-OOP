// ------------------------------------DEMO----------------------------------------------


// struct - OOP (Encapsulation)

public struct Employee
{
    private string name;
    private string title;
    private decimal salary;

    public Employee(string name, string title, decimal salary)
    {

        this.name = name;
        this.title = title;
        this.salary = salary;
    }

    public string Name
    {
        get { return name; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name Cannot be empty");
            }
            name = value;
        }
    }


    public string Title
    {
        get { return title; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title Cannot be empty");
            }

            title = value;
        }


    }

    public decimal Salary
    {
        get { return salary; }

        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative");
            salary = value;
        }
    }


    public override string ToString()
    {
        return $"name is {Name} and title is {Title} and salary is {Salary:C}";
    }

}


class Program
{
    static void Main(string[] args)
    {

        try
        {
            Employee employee = new Employee("Shehab", "Software Engineer", 8000);
            Console.WriteLine(employee);

           
        }
        catch(ArgumentException ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
        }


    }
}




// -------------------------Assignments-------------------------


// ---------------------------- Part 01 -------------------------------------------

#region Q1



// // Define the Point struct
// struct Point
// {
//     public double X { get; set; }
//     public double Y { get; set; }

//     // Constructor to initialize the Point
//     public Point(double x, double y)
//     {
//         X = x;
//         Y = y;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the coordinates of the first point (X1 Y1):");
//         string[] input1 = Console.ReadLine().Split(' ');
//         double x1 = double.Parse(input1[0]);
//         double y1 = double.Parse(input1[1]);

//         Console.WriteLine("Enter the coordinates of the second point (X2 Y2):");
//         string[] input2 = Console.ReadLine().Split(' ');
//         double x2 = double.Parse(input2[0]);
//         double y2 = double.Parse(input2[1]);

//         // Create Point instances
//         Point point1 = new Point(x1, y1);
//         Point point2 = new Point(x2, y2);

//         // Calculate the distance
//         double distance = CalculateDistance(point1, point2);

//         Console.WriteLine($"The distance between the two points is: {distance:F2}");
//     }

//     // Method to calculate the distance between two points
//     static double CalculateDistance(Point p1, Point p2)
//     {
//         double dx = p2.X - p1.X;
//         double dy = p2.Y - p1.Y;
//         return Math.Sqrt(dx * dx + dy * dy);
//     }
// }

#endregion

#region Q2
// using System;

// // Define the Person struct
// struct Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     // Constructor to initialize the Person
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person[] persons = new Person[3];

//         // Input details of 3 persons
//         for (int i = 0; i < 3; i++)
//         {
//             Console.WriteLine($"Enter the name of person {i + 1}:");
//             string name = Console.ReadLine();

//             Console.WriteLine($"Enter the age of person {i + 1}:");
//             int age = int.Parse(Console.ReadLine());

//             persons[i] = new Person(name, age);
//         }

//         // Find the oldest person
//         Person oldest = persons[0];

//         for (int i = 1; i < persons.Length; i++)
//         {
//             if (persons[i].Age > oldest.Age)
//             {
//                 oldest = persons[i];
//             }
//         }

//         // Display the name and age of the oldest person
//         Console.WriteLine($"The oldest person is {oldest.Name} with {oldest.Age} years.");
//     }
// }

#endregion


// ---------------------------- Part 02 -------------------------------------------
#region Q1

//     using System;

// // Enum for Security Levels
// public enum SecurityLevel
// {
//     Guest,
//     Developer,
//     Secretary,
//     DBA
// }

// public class Employee
// {
//     // Properties
//     public int ID { get; set; }
//     public string Name { get; set; }
//     private string gender;
//     public string Gender
//     {
//         get { return gender; }
//         set
//         {
//             if (value == "M" || value == "F")
//             {
//                 gender = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Gender must be 'M' or 'F'.");
//             }
//         }
//     }
//     public SecurityLevel SecurityPrivilege { get; set; }
//     public decimal Salary { get; set; }
//     public DateTime HireDate { get; set; }

//     // Constructor
//     public Employee(int id, string name, string gender, SecurityLevel securityPrivilege, decimal salary, DateTime hireDate)
//     {
//         ID = id;
//         Name = name;
//         Gender = gender;
//         SecurityPrivilege = securityPrivilege;
//         Salary = salary;
//         HireDate = hireDate;
//     }

//     // Override ToString to represent Employee data
//     public override string ToString()
//     {
//         return $"Employee ID: {ID}\nName: {Name}\nGender: {Gender}\nSecurity Level: {SecurityPrivilege}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate:yyyy-MM-dd}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             // Create an Employee object
//             Employee emp = new Employee(
//                 id: 101,
//                 name: "Alice Johnson",
//                 gender: "F",
//                 securityPrivilege: SecurityLevel.Developer,
//                 salary: 75000.50m,
//                 hireDate: new DateTime(2020, 5, 15)
//             );

//             // Display the employee details
//             Console.WriteLine(emp);
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }
// }

#endregion

#region Q2

// public class HiringDate
// {
//     // Fields
//     private int day;
//     private int month;
//     private int year;

//     // Properties
//     public int Day
//     {
//         get { return day; }
//         set
//         {
//             if (value >= 1 && value <= 31)
//             {
//                 day = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Day must be between 1 and 31.");
//             }
//         }
//     }

//     public int Month
//     {
//         get { return month; }
//         set
//         {
//             if (value >= 1 && value <= 12)
//             {
//                 month = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Month must be between 1 and 12.");
//             }
//         }
//     }

//     public int Year
//     {
//         get { return year; }
//         set
//         {
//             if (value >= 1900 && value <= DateTime.Now.Year)
//             {
//                 year = value;
//             }
//             else
//             {
//                 throw new ArgumentException($"Year must be between 1900 and {DateTime.Now.Year}.");
//             }
//         }
//     }

//     // Constructor
//     public HiringDate(int day, int month, int year)
//     {
//         Day = day;
//         Month = month;
//         Year = year;
//     }

//     // Override ToString to represent the Hiring Date
//     public override string ToString()
//     {
//         return $"{Day:D2}/{Month:D2}/{Year}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             // Create a HiringDate object
//             HiringDate hireDate = new HiringDate(day: 15, month: 5, year: 2020);

//             // Display the hiring date
//             Console.WriteLine($"Hiring Date: {hireDate}");
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }
// }

#endregion

#region Q3

// // Enum for Security Levels
// public enum SecurityLevel
// {
//     Guest,
//     Developer,
//     Secretary,
//     DBA,
//     SecurityOfficer
// }

// public class Employee
// {
//     // Properties
//     public int ID { get; set; }
//     public string Name { get; set; }
//     private string gender;
//     public string Gender
//     {
//         get { return gender; }
//         set
//         {
//             if (value == "M" || value == "F")
//             {
//                 gender = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Gender must be 'M' or 'F'.");
//             }
//         }
//     }
//     public SecurityLevel SecurityPrivilege { get; set; }
//     private decimal salary;
//     public decimal Salary
//     {
//         get { return salary; }
//         set
//         {
//             if (value >= 0)
//             {
//                 salary = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Salary cannot be negative.");
//             }
//         }
//     }
//     public HiringDate HireDate { get; set; }

//     // Constructor
//     public Employee(int id, string name, string gender, SecurityLevel securityPrivilege, decimal salary, HiringDate hireDate)
//     {
//         ID = id;
//         Name = name;
//         Gender = gender;
//         SecurityPrivilege = securityPrivilege;
//         Salary = salary;
//         HireDate = hireDate;
//     }

//     // Override ToString to represent Employee data
//     public override string ToString()
//     {
//         return $"Employee ID: {ID}\nName: {Name}\nGender: {Gender}\nSecurity Level: {SecurityPrivilege}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate}";
//     }
// }

// // HiringDate class as implemented earlier
// public class HiringDate
// {
//     public int Day { get; set; }
//     public int Month { get; set; }
//     public int Year { get; set; }

//     public HiringDate(int day, int month, int year)
//     {
//         if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > DateTime.Now.Year)
//         {
//             throw new ArgumentException("Invalid date components.");
//         }

//         Day = day;
//         Month = month;
//         Year = year;
//     }

//     public override string ToString()
//     {
//         return $"{Day:D2}/{Month:D2}/{Year}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             // Create an array of Employees
//             Employee[] EmpArr = new Employee[3];

//             EmpArr[0] = new Employee(
//                 id: 1,
//                 name: "Alice",
//                 gender: "F",
//                 securityPrivilege: SecurityLevel.DBA,
//                 salary: 90000m,
//                 hireDate: new HiringDate(1, 6, 2015)
//             );

//             EmpArr[1] = new Employee(
//                 id: 2,
//                 name: "Bob",
//                 gender: "M",
//                 securityPrivilege: SecurityLevel.Guest,
//                 salary: 50000m,
//                 hireDate: new HiringDate(15, 7, 2021)
//             );

//             EmpArr[2] = new Employee(
//                 id: 3,
//                 name: "Charlie",
//                 gender: "M",
//                 securityPrivilege: SecurityLevel.SecurityOfficer,
//                 salary: 120000m,
//                 hireDate: new HiringDate(10, 3, 2010)
//             );

//             // Display the details of all employees
//             foreach (var emp in EmpArr)
//             {
//                 Console.WriteLine(emp);
//                 Console.WriteLine("----------------------");
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }
// }

#endregion

#region Q4
//     // Enum for Security Levels
// public enum SecurityLevel
// {
//     Guest,
//     Developer,
//     Secretary,
//     DBA,
//     SecurityOfficer
// }

// public class Employee : IComparable<Employee>
// {
//     // Properties
//     public int ID { get; set; }
//     public string Name { get; set; }
//     private string gender;
//     public string Gender
//     {
//         get { return gender; }
//         set
//         {
//             if (value == "M" || value == "F")
//             {
//                 gender = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Gender must be 'M' or 'F'.");
//             }
//         }
//     }
//     public SecurityLevel SecurityPrivilege { get; set; }
//     private decimal salary;
//     public decimal Salary
//     {
//         get { return salary; }
//         set
//         {
//             if (value >= 0)
//             {
//                 salary = value;
//             }
//             else
//             {
//                 throw new ArgumentException("Salary cannot be negative.");
//             }
//         }
//     }
//     public HiringDate HireDate { get; set; }

//     // Constructor
//     public Employee(int id, string name, string gender, SecurityLevel securityPrivilege, decimal salary, HiringDate hireDate)
//     {
//         ID = id;
//         Name = name;
//         Gender = gender;
//         SecurityPrivilege = securityPrivilege;
//         Salary = salary;
//         HireDate = hireDate;
//     }

//     // Implement IComparable to sort by HireDate
//     public int CompareTo(Employee other)
//     {
//         return new DateTime(HireDate.Year, HireDate.Month, HireDate.Day)
//             .CompareTo(new DateTime(other.HireDate.Year, other.HireDate.Month, other.HireDate.Day));
//     }

//     // Override ToString to represent Employee data
//     public override string ToString()
//     {
//         return $"Employee ID: {ID}\nName: {Name}\nGender: {Gender}\nSecurity Level: {SecurityPrivilege}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate}";
//     }
// }

// HiringDate class as implemented earlier
// public class HiringDate
// {
//     public int Day { get; set; }
//     public int Month { get; set; }
//     public int Year { get; set; }

//     public HiringDate(int day, int month, int year)
//     {
//         if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > DateTime.Now.Year)
//         {
//             throw new ArgumentException("Invalid date components.");
//         }

//         Day = day;
//         Month = month;
//         Year = year;
//     }

//     public override string ToString()
//     {
//         return $"{Day:D2}/{Month:D2}/{Year}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             // Create an array of Employees
//             Employee[] EmpArr = new Employee[3];

//             EmpArr[0] = new Employee(
//                 id: 1,
//                 name: "Alice",
//                 gender: "F",
//                 securityPrivilege: SecurityLevel.DBA,
//                 salary: 90000m,
//                 hireDate: new HiringDate(1, 6, 2015)
//             );

//             EmpArr[1] = new Employee(
//                 id: 2,
//                 name: "Bob",
//                 gender: "M",
//                 securityPrivilege: SecurityLevel.Guest,
//                 salary: 50000m,
//                 hireDate: new HiringDate(15, 7, 2021)
//             );

//             EmpArr[2] = new Employee(
//                 id: 3,
//                 name: "Charlie",
//                 gender: "M",
//                 securityPrivilege: SecurityLevel.SecurityOfficer,
//                 salary: 120000m,
//                 hireDate: new HiringDate(10, 3, 2010)
//             );

//             // Sort the employees by hire date
//             Array.Sort(EmpArr);

//             // Print the sorted array and count boxing/unboxing
//             int boxingCount = 0;
//             int unboxingCount = 0;

//             Console.WriteLine("Sorted Employees by Hire Date:\n");
//             foreach (var emp in EmpArr)
//             {
//                 Console.WriteLine(emp);
//                 Console.WriteLine("----------------------");

//                 // Simulate boxing and unboxing (for demonstration purposes)
//                 object boxed = emp; // Boxing
//                 boxingCount++;

//                 Employee unboxed = (Employee)boxed; // Unboxing
//                 unboxingCount++;
//             }

//             Console.WriteLine($"Boxing occurred: {boxingCount} times");
//             Console.WriteLine($"Unboxing occurred: {unboxingCount} times");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }
// }

#endregion