namespace cs_con_EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Salary salary = new Salary(20000, 2000, 1000, 4000);
            Console.WriteLine("Total salary of employee is: {0}",salary.calSalary());
        }
        
    }
    class Salary
    {
        int basic, TA, DA, HRA;
        public Salary(int b, int t, int d, int h) 
        {
            this.basic = b;
            this.TA = t;
            this.DA = d;
            this.HRA = h;
        }
        public int calSalary()
        { 
            return basic + TA + DA + HRA;
        }

    }
}