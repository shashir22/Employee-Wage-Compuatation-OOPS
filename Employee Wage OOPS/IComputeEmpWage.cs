using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage_Using_Ooops
{
    interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }
}