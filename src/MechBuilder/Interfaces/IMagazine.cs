using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMagazine : IAmmo {
        List<IMagazineOption> Options { get; set; }
    }
}