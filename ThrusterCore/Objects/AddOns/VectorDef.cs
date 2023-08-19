using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Vectoring Thrusters
namespace ThrusterCore.Objects.AddOns
{
    abstract class VectorDef
    {
        float maxEleveation = 45;
        float maxAzimuth = 45;

        string elevationName = string.Empty;
        string azimuthName = string.Empty;
    }
}
