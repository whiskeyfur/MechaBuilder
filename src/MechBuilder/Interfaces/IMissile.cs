using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMissile : IAmmo {
        List<IMissileOption> Options { get; set; }
    }
}