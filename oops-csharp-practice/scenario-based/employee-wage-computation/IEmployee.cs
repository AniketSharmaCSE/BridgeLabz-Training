namespace Employee
{
    interface IEmployee
    {
        void AddEmployee();
        void AttendanceCheck();
        void DisplayEmployee();
        void CalculateDailyWage(); //UC2
        void CalculateMonthlyWage(); //UC5
        void CalculateWageTillCondition(); //UC6


    }
}
