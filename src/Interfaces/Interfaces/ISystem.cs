using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface ISystem {
        /// <summary>
        /// 
        /// </summary>
        event SystemChangedDelegate Changed;

        /// <summary>
        /// 
        /// </summary>
        ISystemCollection Contains { get; }
        /// <summary>
        /// 
        /// </summary>
        double Cost { get; }
        /// <summary>
        /// 
        /// </summary>
        double Weight { get; set; }
    }
}