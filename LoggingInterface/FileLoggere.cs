using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingInterface
{
    class FileLogger : ILogger
    {
        public void WriteToLog(string message)
        {
            var filewriter = File.AppendText("log.txt");
            filewriter.WriteLine(message);
            filewriter.Close();
        }
    }
}
