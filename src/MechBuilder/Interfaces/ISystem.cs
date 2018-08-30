using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface ISystem
    {
        /// <summary>
        /// 
        /// </summary>
        event SystemChangedDelegate Changed;

        /// <summary>
        /// 
        /// </summary>
        ISystemCollection Systems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        double Cost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        double Weight { get; set; }
    }
}