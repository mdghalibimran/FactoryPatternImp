using BaseTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DbProcessor : IProcessor
    {
        public void Process(string input, string output)
        {
            Do();
        }

        private void Do()
        {
            Console.WriteLine("Called DbProcessor...");
        }
    }
}
