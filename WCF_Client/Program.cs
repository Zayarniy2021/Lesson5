using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();

            string s=client.Sum("1", "2");
            Console.WriteLine(s); ;
            Console.ReadKey();
        }
    }
}
