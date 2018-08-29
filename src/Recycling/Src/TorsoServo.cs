using MechBuilder.Base;
using System;
using static MechBuilder.Lookup;

namespace MechBuilder {
    public class Servo : BaseSystem {
        private Classes _class;
        /// <summary>
        /// This determines how we treat the servo.
        /// </summary>
        public string ServoType { get; set; }
        /// <summary>
        /// This stores how many extra kills/extra spaces are requested.
        /// </summary>
        public int ExtraKills { get; set; }
        public double GetCost(bool recursive) {
            double x = (double)Class;
            switch (ServoType){
                case "Arm":
                case "Leg":
                    x = x + 1.0;
                    break;
                case "Torso":
                    x = x * 2.0;
                    break;
                case "Head":
                case "Wing":
                case "Tail":
                case "Pod":
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
            switch (ServoType)
            {
                case "Arm":
                case "Leg":
                    x = x + 1.0;
                    break;
                case "Torso":
                    x = x * 2.0;
                    break;
                case "Pod":
                    x = 0.0;
                    break;
                case "Head":
                case "Wing":
                case "Tail":
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
            switch (this.ServoType)
            {
                case "Arm":
                case "Leg":
                    x = x + 1.0;
                    break;
                case "Torso":
                case "Pod":
                    x = x * 2.0;
                    break;
                case "Head":
                case "Wing":
                case "Tail":
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
