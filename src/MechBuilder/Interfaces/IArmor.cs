using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IArmor : ISystem {
        /// <summary>
        /// 
        /// </summary>
        int SP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Absorption { get; set; }
    }
}