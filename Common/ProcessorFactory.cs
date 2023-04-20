using BaseTypes;
using Business;

namespace Common
{
    public class ProcessorFactory
    {
        public IProcessor GetProcessor(ProcessorType type)
        {
            switch (type)
            {
                case ProcessorType.File:
                    return new FileProcessor();
                case ProcessorType.Database:
                    return new DbProcessor();
                default: throw new System.NotImplementedException();
            }
        }
    }
    
    public enum ProcessorType
    {
        None = 0,
        File,
        Database
    }
}
