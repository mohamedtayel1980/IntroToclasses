namespace IntroToclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an Employee object
            Employee johan = new Employee(1, "Johan", "Wick");// instance created in memory 
            Employee ahmed = new Employee();// no default constructor if you define your constructor

            johan.DisplayEmployeeDetails();

            // Performing work
            johan.PerformWork(); 
            johan.PerformWork(4); 

            
            double pay = johan.ReceivePay();

            int number = 30;
            johan.UpdateAddress("456 New St", "Los Angeles", "CA", "90001", "USA");
           
            johan.DisplayEmployeeDetails();
        }
    }
}
