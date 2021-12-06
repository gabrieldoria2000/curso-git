using System.Globalization;

namespace ConsolePrimeiro
{
    internal class funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
