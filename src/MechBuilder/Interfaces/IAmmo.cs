using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IAmmo : ISystem {
        /// <summary>
        /// 
        /// </summary>
        int Count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Expended { get; set; }
    }
}