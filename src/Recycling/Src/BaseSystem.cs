using System.Collections.Generic;
using System.ComponentModel;

namespace MechBuilder.Base {
    public abstract class BaseSystem {
        public BaseSystem() {
            this.Name = "New System";
            this._cost = 0.0;
            this._step = 0;
        }

        private string _name;
        private double _cost;
        private int _step;

        [Category("BaseSystem"),
        DefaultValueAttribute("New System"),
        DescriptionAttribute("System Name")]
        public string Name { get => _name; set => _name = value; }

        [Category("BaseSystem"),
        DescriptionAttribute("Cost")]
        public double Cost { get => _cost; }
        [Category("BaseSystem"),
                DescriptionAttribute("Step")]
        public int Step { get => _step; }

        public List<BaseSystem> SubSystems = new List<BaseSystem>();

    }
}
