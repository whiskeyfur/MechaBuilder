using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IEnergyClip : IAmmo {
        /// <summary>
        /// 
        /// </summary>
        List<IEnergyClipOption> Options { get; set; }
    }
}