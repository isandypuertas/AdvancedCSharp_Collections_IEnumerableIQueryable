
namespace AdvancedCSharp_IEnumerableIQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this project needs packages: Microsoft.Extensions.Logging.Console, Microsoft.EntityFrameworkCore.SqlServer and Microsoft.EntityFrameworkCore
            IEnumerableTest();
            IQueryableTest();
        }

        private static void IEnumerableTest()
        {
            EmployeeDBContext context = new EmployeeDBContext("Server=NB-IPUERTAS\\SQL2016;\r\nDatabase=LocalDatabase;\r\nTrusted_Connection=True;\r\nTrustServerCertificate=True;\r\n");
            IEnumerable<Employee> employees = context.Employees.Where(e => e.Id > 1);
            employees = employees.Take(2);
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name:{employee.FirstName.Trim()} {employee.LastName.Trim()} Address:{employee.Address.Trim()}");
            }
        }

        private static void IQueryableTest()
        {
            EmployeeDBContext context = new EmployeeDBContext("Server=.\\SQL2016;\r\nDatabase=LocalDatabase;\r\nTrusted_Connection=True;\r\nTrustServerCertificate=True;\r\n");
            IQueryable<Employee> employees = context.Employees.Where(e => e.Id > 1);
            employees = employees.Take(2);
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name:{employee.FirstName.Trim()} {employee.LastName.Trim()} Address:{employee.Address.Trim()}");
            }
        }
    }
}

