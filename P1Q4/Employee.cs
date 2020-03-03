namespace P1Q4
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        
    }
}