using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseTypes;

namespace Business
{
    public class FileProcessor : IProcessor
    {
        public void Process(string input, string output)
        {
            Do();
        }

        private void Do()
        {
            Console.WriteLine("Called File Processor...");
        }
    }
}
