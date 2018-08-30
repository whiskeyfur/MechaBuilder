using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MechBuilder.Lookup;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IServo : ISystem {
        /// <summary>
        /// 
        /// </summary>
        IArmor Armor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Kills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Spaces { get; set; }
        /// <summary>
        /// 
        /// </summary>
        Classes Class { get; set; }
        ICommandArmor CommandArmor { get; set; }
        IHydraulics IHydraulics { get; set; }
    }
}