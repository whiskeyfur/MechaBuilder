using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMissile : IAmmo {
        /// <summary>
        /// 
        /// </summary>
        List<IMissileOption> Options { get; set; }
    }
}