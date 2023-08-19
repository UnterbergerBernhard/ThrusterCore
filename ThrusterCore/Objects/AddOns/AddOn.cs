using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrusterCore.Objects.AddOns
{
    public abstract class AddOn
    {
        public abstract void Run(IMyFunctionalBlock thruster);
    }
}
