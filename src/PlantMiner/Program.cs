using PlantMiner.Mining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            if (MainAsync().Result)
            {

            }
        }

        static async Task<bool> MainAsync()
        {
            Wikipedia wikipedia = new Wikipedia();
            await wikipedia.GetSectionData("Plant");

            return true;
        }
    }
}
