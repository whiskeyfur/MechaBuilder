using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IActiveShield : IShield
    {
        /// <summary>
        /// 
        /// </summary>
        ActiveShieldOptions Options { get; set; }
    }
}