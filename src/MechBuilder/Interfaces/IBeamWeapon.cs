using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IBeamWeapon : IRangedWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<IEnergyClip> Clips { get; set; }
        List<IBeamWeaponOption> Options { get; set; }
    }
}