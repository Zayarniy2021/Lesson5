using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMXClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WebServiceSoapClient client = new ServiceReference1.WebServiceSoapClient();
            string sum = client.Summ("1", "2");

            Console.WriteLine(sum); ;
            Console.ReadKey();
        }
    }
}
