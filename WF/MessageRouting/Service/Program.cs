using System;
using System.Activities.DurableInstancing;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DurableInstancing;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static InstanceStore instanceStore;

        static void Main(string[] args)
        {
        }

        private static void SetupInstanceStore()
        {
            instanceStore =
                new SqlWorkflowInstanceStore(@"Data Source=.\SQLEXPRESS;Initial Catalog=MessageRoutingInstanceStore;Integrated Security=True;Asynchronous Processing=True");

            InstanceHandle handle = instanceStore.CreateInstanceHandle();
            InstanceView view = instanceStore.Execute(handle, new CreateWorkflowOwnerCommand(), TimeSpan.FromSeconds(30));
            handle.Free();

            instanceStore.DefaultInstanceOwner = view.InstanceOwner;
        }
    }
}
