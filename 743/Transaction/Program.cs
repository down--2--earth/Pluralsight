using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TransactionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Task();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

        static void Task()
        {
            Console.WriteLine(Transaction.Current.TransactionInformation.LocalIdentifier);
            throw new Exception("ss");
        }
    }
}
