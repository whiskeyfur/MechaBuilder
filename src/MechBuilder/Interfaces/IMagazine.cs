using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMagazine : IAmmo {
        /// <summary>
        /// 
        /// </summary>
        List<IMagazineOption> Options { get; set; }
    }
}