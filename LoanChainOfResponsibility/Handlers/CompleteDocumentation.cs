using LoanChainOfResponsibility.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanChainOfResponsibility.Handlers
{
   public class CompleteDocumentation: DefaultHandler
    {
        public override object Handle(Loan loan)
        {
            if (loan.HasCompleteDocumentation)
                return "YOUR LOAN IS APRROVED";
            else
                return "YOUR LOAN IS NOT APRROVED";
        }
    }
}
