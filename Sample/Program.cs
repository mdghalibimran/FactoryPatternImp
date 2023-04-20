using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessorFactory processorFactory = new ProcessorFactory();

            var processor = processorFactory.GetProcessor(ProcessorType.File);
            processor.Process(string.Empty, string.Empty);

            processor = processorFactory.GetProcessor(ProcessorType.Database);
            processor.Process(string.Empty, string.Empty);

            Console.ReadLine();
        }
    }
}
