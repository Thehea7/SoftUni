using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BirthdayCelebrations.Models.Interfaces
{
    public interface IBuyer
    { 
        int Food { get; }
        public string Name { get; init; }
        void BuyFood();
    }
}
