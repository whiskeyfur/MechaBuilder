using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IEnergyMeleeWeapon : IReachWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<IEnergyMeleeWeaponOption> Options { get; set; }
    }
}