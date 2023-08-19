using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Afterburner
namespace ThrusterCore.Objects.AddOns
{
    public class AfterburnerDef : AddOn
    {
        float extraThrust = .68f; //how much extra thrust to add
        float extraConsumption = .4f; //how much extra power/fuel to use

        public override void Run(IMyFunctionalBlock thruster)
        {
            throw new NotImplementedException();
        }
    }
}
