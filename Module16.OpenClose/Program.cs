using Module16.OpenClose;

Account standartAcc = new StandartAccount
{
    Balance = 10000,
    Interest = 200
};

Account salaryAcc = new SalaryAccount
{
    Balance = 20000,
    Interest = 20
};

Calculator.Calculate(standartAcc);
Calculator.Calculate(salaryAcc);