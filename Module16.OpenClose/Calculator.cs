using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.OpenClose
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void Calculate(Account account)
        {

            account.CalculateInterest();
        }
    }
}
