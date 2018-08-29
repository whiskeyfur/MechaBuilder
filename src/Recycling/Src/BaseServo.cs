using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public abstract class BaseServo : Base.BaseSystem {

        public enum ServoType {
            Torso,
            Head,
            Arm,
            Leg,
            Wing,
            Tail,
            Pod
        }
    }
}