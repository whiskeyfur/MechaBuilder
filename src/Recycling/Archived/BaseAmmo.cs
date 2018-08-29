using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public abstract class BaseAmmo : BaseSystem {
        public int Rounds = 0;
        public int Expended = 0;
    }
}