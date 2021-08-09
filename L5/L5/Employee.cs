using System;
using System.Collections.Generic;
using System.Text;

namespace L5
{
	class Employee
	{
		private string name;
		private string position;
		private string email;
		private string phone;
		private int salary;
		private int age;

		public Employee(string name, string position, string email, string phone, int salary, int age)
		{
			this.name = name;
			this.position = position;
			this.email = email;
			this.phone = phone;
			this.salary = salary;
			this.age = age;
		}
		public int getAge()
		{
			return age;
		}
		public string GetInfo()
		{
			return (name + "\n-"
				+ position + "\n-"
				+ email + "\n-"
				+ phone + "\n-"
				+ salary + "\n-"
				+ age);
		}
	}
}
