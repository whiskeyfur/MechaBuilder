using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IEnergyPool : IWeapon {
        /// <summary>
        /// 
        /// </summary>
        List<ISystem> Portfolios { get; set; }
        /// <summary>
        /// 
        /// </summary>
        bool Morphable { get; set; }
    }
}