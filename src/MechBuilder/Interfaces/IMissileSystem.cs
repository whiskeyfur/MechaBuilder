using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMissileSystem : IRangedWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<IMissile> Missiles { get; }
    }
}