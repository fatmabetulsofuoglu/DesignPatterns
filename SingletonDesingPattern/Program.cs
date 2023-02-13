using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesingPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }

        class CustomerManager
        {
            private static CustomerManager _customerManager;
            private CustomerManager()
            {

            }

            public static CustomerManager CreateAsSingleton()
            {
                return _customerManager ?? (_customerManager = new CustomerManager());
            }

            public void Save()
            {
                Console.WriteLine("Saved!");
            }
        }
    }
}
