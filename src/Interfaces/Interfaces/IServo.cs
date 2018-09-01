using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MechBuilder.API.Lookup;

namespace MechBuilder.API {
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
        /// <summary>
        /// 
        /// </summary>
        ICommandArmor CommandArmor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        IHydraulics IHydraulics { get; set; }
    }
}