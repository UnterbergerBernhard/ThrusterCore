using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrusterCore.Objects.AddOns;
using VRage.Game.Components;
using VRage.ObjectBuilders;

namespace Thruster_Core.Objects
{
    abstract class Thruster : MyGameLogicComponent
    {
        public List<AddOn> AddOns = new List<AddOn>();

        private IMyFunctionalBlock? block;

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            base.Init(objectBuilder);
            block = (IMyFunctionalBlock)objectBuilder;

            NeedsUpdate = VRage.ModAPI.MyEntityUpdateEnum.BEFORE_NEXT_FRAME;
        }

        public override void UpdateOnceBeforeFrame()
        {
            base.UpdateOnceBeforeFrame();

            

            NeedsUpdate = VRage.ModAPI.MyEntityUpdateEnum.EACH_FRAME;
        }

        public override void UpdateAfterSimulation()
        {
            base.UpdateAfterSimulation();
            foreach (AddOn addOn in AddOns)
            {
                addOn.Run(block!);
            }
        }
    }
}
