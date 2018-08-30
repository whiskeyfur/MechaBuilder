using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public interface IEnergyPool : IWeapon {
        List<ISystem> Portfolios { get; set; }
        bool Morphable { get; set; }
    }
}