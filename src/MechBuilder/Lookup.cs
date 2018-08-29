using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechBuilder {

    /// <summary>
    /// Container to hold a lot of commonly used lookup values.
    /// </summary>
    public sealed class Lookup {
        /// <summary>
        ///  No reason to have this publically accessible. Lookup doesn't do anything.
        /// </summary>
        private Lookup() {

        }

        /// <summary>
        /// These are the classes of servo, and other systems, higher number is more expensive/stronger.
        /// </summary>
        public enum Classes : byte {
            /// <summary>
            /// 
            /// </summary>
            None,
            /// <summary>
            /// 
            /// </summary>
            Superlight,
            /// <summary>
            /// 
            /// </summary>
            Lightweight,
            /// <summary>
            /// 
            /// </summary>
            Striker,
            /// <summary>
            /// 
            /// </summary>
            Medium_Striker,
            /// <summary>
            /// 
            /// </summary>
            Heavy_Striker,
            /// <summary>
            /// 
            /// </summary>
            Mediumweight,
            /// <summary>
            /// 
            /// </summary>
            Light_Heavy,
            /// <summary>
            /// 
            /// </summary>
            Medium_Heavy,
            /// <summary>
            /// 
            /// </summary>
            Armored_Heavy,
            /// <summary>
            /// 
            /// </summary>
            Super_Heavy,
            /// <summary>
            /// 
            /// </summary>
            Mega_Heavy
        }

        /// <summary>
        /// The various armor types are defined here, along with the relevant damage coefficients.
        /// </summary>
        public enum ArmorType : byte {
            /// <summary>
            /// 
            /// </summary>
            Ablative = 0,
            /// <summary>
            /// 
            /// </summary>
            Standard = 1,
            /// <summary>
            /// 
            /// </summary>
            Alpha = 2,
            /// <summary>
            /// 
            /// </summary>
            Beta = 4,
            /// <summary>
            /// 
            /// </summary>
            Gamma = 8
        }

        /// <summary>
        /// These are the types of radiation absorbing material armor modifiers.
        /// </summary>
        public enum RadiationAbsorption : byte
        {
            /// <summary>
            /// No absorption, no cost modifier.
            /// </summary>
            None,
            /// <summary>
            /// 1/2 absorption, 2.5x cost multiplier, 2/3rd SP penalty
            /// </summary>
            Second = 2,
            /// <summary>
            /// 2/3rds absorption, 2.2x cost multiplier, 3/4th SP penalty
            /// </summary>
            Third,
            /// <summary>
            /// 1/4th absorption, 1.8x cost multiplier, 4/5th SP penalty
            /// </summary>
            Fourth,
            /// <summary>
            /// 1/5th absorption, 1.5x cost multiplier, No SP penalty
            /// </summary>
            Fifth
        }
    }
}
