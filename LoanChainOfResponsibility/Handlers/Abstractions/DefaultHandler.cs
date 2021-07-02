using LoanChainOfResponsibility.Handlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanChainOfResponsibility.Handlers
{
    class DefaultHandler : IHandler
    {
        private IHandler _next;
        public virtual object Handle(Loan loan)
        {
            return _next?.Handle(loan);
        }

        public IHandler SetNext(IHandler handler)
        {
            _next = handler;

            return _next;
        }
    }
}
