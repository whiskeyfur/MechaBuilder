using MechBuilder.Base;
using System;
using static MechBuilder.Lookup;

namespace MechBuilder {
    public class Servo : BaseServo {
        private Classes _class;
        /// <summary>
        /// This determines how we treat the servo.
        /// </summary>
        public ServoType Type { get; set; }
        /// <summary>
        /// This stores how many extra kills/extra spaces are requested.
        /// </summary>
        public int ExtraKills { get; set; }
        public double GetCost(bool recursive) {
            double x = (double)Class;
            switch (Type) {
                case ServoType.Arm:
                case ServoType.Leg:
                    x = x + 1.0;
                    break;
                case ServoType.Torso:
                    x = x * 2.0;
                    break;
                case ServoType.Head:
                case ServoType.Wing:
                case ServoType.Tail:
                case ServoType.Pod:
                default:
                    break;
            }
            return x;
        }
        /// <summary>
        /// This function returns how many kills of structure this servo has.
        /// </summary>
        /// <param name="recursive"></param>
        /// <returns></returns>
        public double GetStructure(bool recursive) {
            double x = (double)Class;
            switch (Type) {
                case ServoType.Arm:
                case ServoType.Leg:
                    x = x + 1.0;
                    break;
                case ServoType.Torso:
                    x = x * 2.0;
                    break;
                case ServoType.Pod:
                    x = 0.0;
                    break;
                case ServoType.Head:
                case ServoType.Wing:
                case ServoType.Tail:
                default:
                    break;
            }
            int SacrificedKills = Math.Max((int)x - 1, Math.Min(0, ExtraKills));
            x = x - SacrificedKills;
            return x;
        }

        public double GetWeight(bool recursive) {
            return GetStructure(recursive) / 2;
        }

        /// <summary>
        /// This function returns how many spaces are provided/occupied by the servo.
        /// </summary>
        /// <param name="recursive"></param>
        /// <returns></returns>
        public double GetSpaces(bool recursive) {
            double x = (double)this.Class;
            switch (this.Type) {
                case ServoType.Arm:
                case ServoType.Leg:
                    x = x + 1.0;
                    break;
                case ServoType.Torso:
                case ServoType.Pod:
                    x = x * 2.0;
                    break;
                case ServoType.Head:
                case ServoType.Wing:
                case ServoType.Tail:
                default:
                    break;
            }
            int SacrificedKills = Math.Max((int)x - 1, Math.Min(0, ExtraKills));
            x = x + SacrificedKills * 2;
            return x;
        }
        public Classes Class { get => _class; set => _class = value; }
    }
}
