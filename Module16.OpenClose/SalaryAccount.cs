using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.OpenClose
{
    internal class SalaryAccount : Account
    {
        public override double Balance { get; set ; }
        public override double Interest { get; set; }

        public override void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            this.Interest = this.Balance * 0.5;

            Console.WriteLine("SalaryAcc");
        }
    }
}
