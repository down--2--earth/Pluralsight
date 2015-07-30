using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageRouter.ReceiveAdapter;
using System.IO;
using System.Configuration;

namespace MessageRouter.Test.ReceiveAdapter
{
    [TestClass]
    public class ReceiveFileAdapterTest
    {
        [TestMethod]
        public void ReceiveFileTest()
        {
            //IReceiveAdapter iReceiveAdapter = new ReceiveAdapterFactory().CreateReceiveAdapterFactory(); 
            GenerateFiles(10);
        }

        private void GenerateFiles(int count) 
        {
            string receiveDir = ConfigurationManager.AppSettings["ReceiveDir"];
            if (!Directory.Exists(receiveDir))
            {
                Directory.CreateDirectory(receiveDir);
            }

            CreateFile(receiveDir, 20);
        }

        private string CreateFile(string dir, long length)
        {
            string payloadName = Guid.NewGuid().ToString();

            using (FileStream fileStream = new FileStream(Path.Combine(dir, payloadName), FileMode.CreateNew))
            {
                for (int x = 0; x < length; x++)
                {
                    fileStream.WriteByte(1);
                }
            }

            return payloadName;
        }
    }
}
