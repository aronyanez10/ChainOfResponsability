using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanChainOfResponsibility.Handlers.Models
{
   public class Loan
    {

        public bool OnTime { get; set; }

        public decimal Amount { get; set; }

        public bool HasCompleteDocumentation { set; get; }
    }
}
