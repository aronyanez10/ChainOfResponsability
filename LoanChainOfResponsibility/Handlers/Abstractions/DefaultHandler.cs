using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoan.Handlers
{
    class DefaultHandler : IHandler
    {
        private IHandler _next;
        public object Handle(object request)
        {
            return _next?.Handle(request);
        }

        public IHandler SetNext(IHandler handler)
        {
            _next = handler;

            return _next;
        }
    }
}
