namespace P04.Recharge
{
    using System;
    using P04.Recharge.Models.interfaces;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public  void Sleep()
        {
            // sleep...
        }
    }
}
