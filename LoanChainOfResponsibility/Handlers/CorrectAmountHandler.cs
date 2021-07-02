using LoanChainOfResponsibility.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanChainOfResponsibility.Handlers
{
    public class CorrectAmountHandler : DefaultHandler
    {
        private decimal min = 100;
        private decimal max = 1000;
        public override object Handle(Loan loan)
        {
            if (loan.Amount > min && loan.Amount < max)
                return base.Handle(loan);
            else
                return "YOUR LOAN SHOULD BE BETWEEN 100 AND 1000";
        }

    }
}
