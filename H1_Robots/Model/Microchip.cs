using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robots.Model
{
    /// <summary>
    /// Class <see cref="Microchip"/> represents a microchip
    /// </summary>
    internal class Microchip
    {
        private string _name;
        private Abilities[] _abilities;

        public Microchip(string name, Abilities[] abilities)
        {
            _name = name;
            _abilities = abilities;
        }

        public enum Abilities
        {
            CleanFloor,
            CleanWindow,
            ChangeWheels,
            None
        }
    }
}
