using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int employeeType = random.Next(3); 
            Parent employee = null;

            if (employeeType == 0) 
            {
                double stavka = random.Next(1000, 5000);
                employee = new Child1(stavka);
            }
            else if (employeeType == 1) 
            {
                double hours = random.Next(80, 160);
                double rate = random.Next(10, 20);
                employee = new Child2(hours, rate);
            }
            else 
            {
                double salesAmount = random.Next(10000, 50000);
                employee = new Child3(salesAmount);
            }

            employee.Metod1(); 
            employee.Metod2(); 

            Console.WriteLine(employee.Info());
        }
    }
}
