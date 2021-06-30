using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
