using LoanChainOfResponsibility.Handlers;
using LoanChainOfResponsibility.Handlers.Models;
using System;

namespace LoanChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //steps
            var onTime = new OnTimeHandler();
            var correctAmount = new CorrectAmountHandler();
            var completeDocumentation = new CompleteDocumentation();

            //Set steps
            onTime.SetNext(correctAmount).SetNext(completeDocumentation);


            //Manually Test
            Loan loan = new()
            {
                OnTime = true,
                Amount = 15000,
                HasCompleteDocumentation = true
            };

            var result = onTime.Handle(loan);
            if (result != null)
            Console.WriteLine(onTime.Handle(loan));
        }
    }
}
