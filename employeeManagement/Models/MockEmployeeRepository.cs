using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Models
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private List<Employee> _employeeList;
		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>()
			{
				new Employee() { Id = 1 , Name = "Madhav",Department = "cse",Email="madhav1709@gmail.com"},
				new Employee() { Id = 2 , Name = "Rekha",Department = "ece",Email="rekha2772@gmail.com"},
				new Employee() { Id = 3 , Name = "Suresh",Department = "ece",Email="menosuresh@gmail.com"},
				new Employee() { Id = 4 , Name = "Anjana",Department = "law",Email="anjana0298@gmail.com"},

			};
		}

		public IEnumerable<Employee> GetAllEmployee()
		{
			return _employeeList;
		}

		public Employee GetEmployee(int Id)
		{
			return _employeeList.FirstOrDefault(e => e.Id == Id);
		}
	}
}
