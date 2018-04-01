using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadConfigFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = ConfigurationManager.AppSettings["Message"];

            Console.WriteLine("The essage is: {0}", message);

            Console.ReadLine();
        }
    }
}
