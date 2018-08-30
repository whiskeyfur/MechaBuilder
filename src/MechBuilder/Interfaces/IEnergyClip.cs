using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IEnergyClip : IAmmo {
        List<IEnergyClipOption> Options { get; set; }
    }
}