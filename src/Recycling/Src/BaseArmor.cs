using MechBuilder.Interfaces;
using System;
using static MechBuilder.Lookup;

namespace MechBuilder.Base {
    /// <summary>
    /// Basically, armor plates that can be added to nearly any system. 
    /// </summary>
    public abstract class BaseArmor : BaseSystem {

        /// <summary>
        /// 
        /// </summary>
        public ArmorType ArmorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Classes Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RadiationAbsorption RAM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Classes ArmorClass {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public double Weight {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetCost() {
            double x = (double)this.Class;
            switch (this.ArmorType) {
                case (ArmorType.Ablative):
                    x = x * 0.5;
                    break;
                case (ArmorType.Standard):
                    x = x * 1.0;
                    break;
                case (ArmorType.Alpha):
                    x = x * 1.25;
                    break;
                case (ArmorType.Beta):
                    x = x * 1.5;
                    break;
                case (ArmorType.Gamma):
                    x = x * 2.0;
                    break;
                default:
                    throw new Exception("Missing an ArmorType, dummy");
            }
            switch (this.RAM) {
                case (RadiationAbsorption.Second):
                    x = x * 2.5;
                    break;
                case (RadiationAbsorption.Third):
                    x = x * 2.2;
                    break;
                case (RadiationAbsorption.Fourth):
                    x = x * 1.8;
                    break;

                case (RadiationAbsorption.Fifth):
                    x = x * 1.8;
                    break;
                default:
                    break;
            }
            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetWeight() => (double)this.Class * 2;
    }
}
