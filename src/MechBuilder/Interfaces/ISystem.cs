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
        ISystemCollection Contains { get; set; }
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