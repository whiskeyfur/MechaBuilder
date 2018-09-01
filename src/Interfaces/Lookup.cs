using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechBuilder.API {

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


    }
}
