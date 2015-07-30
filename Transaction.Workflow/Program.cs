using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Transaction.Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Activity workflow1 = new Activity1();
                    WorkflowInvoker.Invoke(workflow1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }


        public static string Task1()
        {

            return "AAAAAA";
        }
    }
}
