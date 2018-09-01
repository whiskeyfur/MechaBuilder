using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IProjectileWeapon : IRangedWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<IMagazine> Magazines { get; set; }
        /// <summary>
        /// 
        /// </summary>
        List<IProjectileWeaponOption> Options { get; set; }
    }
}