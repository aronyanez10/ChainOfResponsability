using LoanChainOfResponsibility.Handlers;
using LoanChainOfResponsibility.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanChainOfResponsibility.Handlers
{
    public class OnTimeHandler : DefaultHandler
    {
        public override object Handle(Loan loan)
        {
            if (loan.OnTime)
                return base.Handle(loan);
            else
                return "NOT ON TIME";
        }
    }
}
