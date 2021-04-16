﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    class CompanyEmpWage
    { //instance variable
		public string company;
		public int empRatePerHour;
		public int numOfWorkingDays;
		public int maxHoursPerMonth;
		public int totalEmpWage;

		public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth) //parameterized constructer
		{ 
			//invoke current class constructor
		    this.company = company;
			this.empRatePerHour = empRatePerHour;
			this.numOfWorkingDays = numOfWorkingDays;
			this.maxHoursPerMonth = maxHoursPerMonth;
		}

		public void setTotalEmpWage(int totalEmpWage) //set method
		{
			this.totalEmpWage = totalEmpWage;
		}

		public string toString() //instance method 
		{
			return "total EmpWage for company :" + this.company + " is :" + this.totalEmpWage;
		}
	}
}

