using H1_Robots.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Abililites array for chips
            Microchip.Abilities[] defaultAbilities = { Microchip.Abilities.CleanFloor };
            Microchip.Abilities[] rxAbilities = { Microchip.Abilities.CleanFloor, Microchip.Abilities.CleanWindow };
            Microchip.Abilities[] qtAbilities = { Microchip.Abilities.CleanFloor, Microchip.Abilities.ChangeWheels };

            // Chips
            Microchip defaultChip = new Microchip("DEFAULT", defaultAbilities);
            Microchip rxChip = new Microchip("RX54667", defaultAbilities);
            Microchip qtChip = new Microchip("QT8339", defaultAbilities);

            // Soap container
            SoapContainer soapContainer = new SoapContainer(2.3f);

            // Robots
            Robot robot1 = new Robot("Fejerobot", rxChip, "White", 4, soapContainer);
            Robot robot2 = new Robot("Mekanikerrobot", qtChip, "Red", 4, true);
            Robot robot3 = new Robot("Fejerobot", defaultChip, "White", false, 0);
        }
    }
}
