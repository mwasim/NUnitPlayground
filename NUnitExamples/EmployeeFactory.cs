using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    public class EmployeeFactory
    {
        public object GetEmmployee(bool isManager)
        {
            if (isManager) return new Manager();

            return new Worker();
        }
    }

    public class Employee
    {

    }

    public class Manager : Employee
    {
        public bool CanManageProjects { get { return true; } }
    }

    public class Worker : Employee
    {

    }
}
