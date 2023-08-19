using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thrust Reverser
namespace ThrusterCore.Objects.AddOns
{
    public class ReverserDef : AddOn
    {
        float redirectionPercent = .05f; //with how much % of current thrust to decelerate


        public override void Run(IMyFunctionalBlock thruster)
        {
            throw new NotImplementedException();
        }
    }
}
