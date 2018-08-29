using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IReactiveShield : IShield
    {
        /// <summary>
        /// 
        /// </summary>
        ReactiveShieldOptions Options { get; set; }
    }
}