using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    public interface IOption {
        string Name { get; set; }
        double Multiple { get; set; }
    }
}