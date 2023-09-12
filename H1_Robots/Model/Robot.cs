using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robots.Model
{
    internal class Robot
    {
        private string _name;
        private Microchip _microchip;
        private string _color;
        private bool _isBig;
        private bool _hasWifi;
        private SoapContainer _soapContainer;
        private Battery battery;
        private byte _wheelAmount;

        internal Robot()
        {

        }

        internal Robot(string name, Microchip microchip, string color, byte wheels, Battery battery)
        {

        }

        internal Robot(string name, Microchip microchip, string color, byte wheels, SoapContainer soapContainer)
        {
            
        }
        
    }
}
