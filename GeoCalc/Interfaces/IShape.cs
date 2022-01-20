using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc.Interfaces
{
    public interface IShape
    {
        public float Perimeter();
        public float Area();
    }
}
