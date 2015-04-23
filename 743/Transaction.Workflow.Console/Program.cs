using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Transaction.Workflow.Console
{

    class Program
    {
        static void Main(string[] args)
        {

            using (TransactionScope scope = new TransactionScope())
            {
                System.Console.ReadLine();
            }
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);

            System.Console.ReadLine();
        }

        public static string TestMethod() 
        {



            return "";
        }
    }
}
