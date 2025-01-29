namespace IntroToclasses
{
    public class Employee
    {
        // Properties to store data about the employee
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        // Constant to represent default values
        private const double defaultHourlyRate = 20.0;
        private const int minimalHoursWorkedUnit = 1;

        // Field to store hours worked and hourly rate
        private int numberOfHoursWorked;
        private double hourlyRate;

        
        // Constructor to initialize the employee
        public Employee(int employeeID, string firstName, string lastName, double hourlyRate = defaultHourlyRate)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            this.hourlyRate = hourlyRate;
            numberOfHoursWorked = 0; // Initialize hours worked to zero
        }
        public Employee(string firstName, string lastName)
        {
          
            FirstName = firstName;
            LastName = lastName;
          
        }
        // Method to perform work for the minimum unit of hours
        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        // Overloaded method to perform work for a given number of hours
        public void PerformWork(int hours)
        {
            numberOfHoursWorked += hours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHoursWorked} hours.");
        }

        // Method to receive payment
        public double ReceivePay(bool resetHours = true)
        {
            double wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"{FirstName} {LastName} has been paid {wage:C}.");

            if (resetHours)
            {
                numberOfHoursWorked = 0;
            }

            return wage;
        }

        // Method to update the employee's address
        public void UpdateAddress(string newAddress, string newCity, string newRegion, string newPostalCode, string newCountry)
        {
            Address = newAddress;
            City = newCity;
            Region = newRegion;
            PostalCode = newPostalCode;
            Country = newCountry;

            Console.WriteLine($"{FirstName} {LastName}'s address has been updated.");
        }

        // Method to display full employee information
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {TitleOfCourtesy} {FirstName} {LastName}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Address: {Address}, {City}, {Region}, {Country}");
            Console.WriteLine($"Hire Date: {HireDate?.ToString("d")}");
            Console.WriteLine($"Reports To: {(ReportsTo.HasValue ? ReportsTo.ToString() : "None")}");
        }
    }
}
