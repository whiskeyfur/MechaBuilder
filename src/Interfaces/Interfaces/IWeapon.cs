using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IWeapon : ISystem {
        /// <summary>
        /// 
        /// </summary>
        int Damage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Accuracy { get; set; }
    }
}