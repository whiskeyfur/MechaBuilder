using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IArmor : ISystem {
        int SP { get; set; }
        int Absorption { get; set; }
    }
}