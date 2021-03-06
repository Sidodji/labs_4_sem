using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    [Serializable]
    public class ServerFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new ServerConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new ServerHardware();
        }
    }

    [Serializable]

    public class LaptopFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new LaptopConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new LaptopHardware();
        }
    }

    [Serializable]
    public class WorkStationFactory : IFactory
    {
        public ComputerConfig CreateConfig()
        {
            return new WorkStationConfig();
        }

        public ComputerHardware CreateHardware()
        {
            return new WorkStationHardware();
        }
    }
}
