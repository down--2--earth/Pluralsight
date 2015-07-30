using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageRouter.ReceiveAdapter
{
    class ReceiveFileAdapter : IReceiveAdapter
    {
        public void ReceiveMessages()
        {
            string receiveDir = ConfigurationManager.AppSettings["ReceiveDir"];

            if(!Directory.Exists(receiveDir)) {
                Directory.CreateDirectory(receiveDir);
            }

            string[] fileEntries = Directory.GetFiles(receiveDir);

            string processDir = ConfigurationManager.AppSettings["ProcessDir"];

            Parallel.ForEach(fileEntries, currentFile =>
                {
                    File.Move(currentFile, Path.Combine(processDir, currentFile));
                }
            );

        }
    }
}
