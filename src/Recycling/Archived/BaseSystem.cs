using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MechBuilder {
    public abstract class BaseSystem {
        
        public BaseSystem() {
            this.Name = "New System";
            this.ID = Guid.NewGuid();
        }

        public Guid ID;

        public string Name;

        public List<BaseSystem> SubSystems = new List<BaseSystem>();

    }
}
