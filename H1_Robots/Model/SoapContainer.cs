using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Robots.Model
{
    /// <summary>
    /// Class <see cref="SoapContainer"/> represents a container filled with soap
    /// </summary>
    internal class SoapContainer
    {
        private float _level;

        private const float CAPACITY = 2.3f;

        public SoapContainer(float level)
        {
            _level = level;
        }
    }
}
