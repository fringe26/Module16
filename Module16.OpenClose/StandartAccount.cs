using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module16.OpenClose
{
    internal class StandartAccount :Account
    {
        public override double Balance { get ; set; }
        public override double Interest { get;set ; }

        public override void CalculateInterest()
        {
     
                // расчет процентной ставки обычного аккаунта по правилам банка
                this.Interest = this.Balance * 0.4;
                if (this.Balance < 1000)
                    this.Interest -= this.Balance * 0.2;

                if (this.Balance < 50000)
                    this.Interest -= this.Balance * 0.4;

            Console.WriteLine("StandartAcc");
        }
    }
}
