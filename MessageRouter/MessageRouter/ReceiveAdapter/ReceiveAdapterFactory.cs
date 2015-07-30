using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageRouter.ReceiveAdapter
{
    public class ReceiveAdapterFactory
    {
        public IReceiveAdapter CreateReceiveAdapterFactory()
        {
            return new ReceiveFileAdapter();
        }
    }
}
