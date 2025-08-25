namespace Core_Web_Razor_WiproDemo.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

        public Employee()
        {
            id = 100;
            name = "Wipro Employee";
            email = "employee@wipro.com";
            phone = 1234567;
        }
    }
}
