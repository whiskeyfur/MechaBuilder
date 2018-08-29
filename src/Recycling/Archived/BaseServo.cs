using MechBuilder.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public abstract class DearServo : BaseSystem {

        public enum ServoType {
            Torso,
            Head,
            Arm,
            Leg,
            Wing,
            Tail,
            Pod
        }

        public BaseArmor Armor;

    }
}