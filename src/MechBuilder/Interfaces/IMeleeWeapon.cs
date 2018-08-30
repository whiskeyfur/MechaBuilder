using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMeleeWeapon : IReachWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<IMeleeWeaponOption> Options { get; set; }
    }
}