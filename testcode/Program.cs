namespace testcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Hai", "Da Nang");
            person1.DisplayInfor();
            Console.WriteLine("==================");
            Employee employee1 = new Employee("ABC");
            employee1.name = "Hieu";
            employee1.address = "Da Nang";
            employee1.DisplayInfor();
        }
    }
}