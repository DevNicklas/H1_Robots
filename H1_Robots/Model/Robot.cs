using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robots.Model
{
    /// <summary>
    /// Class <see cref="Robot"/> represents a robot
    /// </summary>
    internal class Robot
    {
        private string _name;
        private Microchip _microchip;
        private string _color;
        private byte _wheelAmount;
        private SoapContainer _soapContainer;
        private bool _hasBattery;
        private bool _hasWifi;

        /// <summary>
        /// Constructs a instance using 2 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        private Robot(string name, Microchip microchip)
        {
            _name = name;
            _microchip = microchip;
        }

        /// <summary>
        /// Constructs a instance of class <see cref="Robot"/> using 3 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        /// <param name="color">color of robot</param>
        private Robot(string name, Microchip microchip, string color) : this(name, microchip)
        {
            if (_color == null)
            {
                _color = "White";
            }
            else
            {
                _color = color;
            }
        }

        /// <summary>
        /// Constructs a instance of class <see cref="Robot"/> using 4 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        /// <param name="color">color of robot</param>
        /// <param name="wheelAmount">amount of wheel the robot has</param>
        private Robot(string name, Microchip microchip, string color, byte wheelAmount) : this(name, microchip, color)
        {
            _wheelAmount = wheelAmount;
        }

        /// <summary>
        /// Constructs a instance of class <see cref="Robot"/> using 5 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        /// <param name="color">color of robot</param>
        /// <param name="wheelAmount">amount of wheel the robot has</param>
        /// <param name="soapContainer">soap container which the robot has</param>
        internal Robot(string name, Microchip microchip, string color, byte wheelAmount, SoapContainer soapContainer) : this(name, microchip, color, wheelAmount)
        {
            _soapContainer = soapContainer;
        }

        /// <summary>
        /// Constructs a instance of class <see cref="Robot"/> using 5 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        /// <param name="color">color of robot</param>
        /// <param name="wheelAmount">amount of wheel the robot has</param>
        /// <param name="hasBattery">does the robot have a battery</param>
        internal Robot(string name, Microchip microchip, string color, byte wheelAmount, bool hasBattery) : this(name, microchip, color, wheelAmount)
        {
            _hasBattery = hasBattery;
        }

        /// <summary>
        /// Constructs a instance of class <see cref="Robot"/> using 5 arguments
        /// </summary>
        /// <param name="name">name of robot</param>
        /// <param name="microchip">microchip in robot</param>
        /// <param name="color">color of robot</param>
        /// <param name="wheelAmount">amount of wheel the robot has</param>
        /// <param name="hasBattery">does the robot have a battery</param>
        internal Robot(string name, Microchip microchip, string color, bool hasBattery, byte wheelAmount) : this(name, microchip, color, wheelAmount, hasBattery)
        {
            _hasWifi = true;
        }
    }
}
