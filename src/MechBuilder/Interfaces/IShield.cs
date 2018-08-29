using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IShield : ISystem
    {
        /// <summary>
        /// Scale of 1 to 20
        /// </summary>
        int SP { get; set; }
    }
}