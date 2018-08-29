using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public enum ICargoOptions
    {
        /// <summary>
        /// Everything is just left on the floor. 
        /// No change to stored systems.
        /// </summary>
        Standard = 1,
        /// <summary>
        /// Systems are stored on shelves and overhead. 
        /// 1/2th of the space required for systems stored here
        /// </summary>
        Efficient = 2,
        /// <summary>
        /// Shelves, overhead hooks, storage and retrieval system. 
        /// 1/3th of the space required for systems stored here
        /// </summary>
        Compact = 3,
        /// <summary>
        /// Barely room to walk, conveyor belts and waldos to retrieve gear.
        /// 1/4th of the space required for systems stored here
        /// </summary>
        BulkStorage = 4,
        /// <summary>
        /// To heck with a storage system, this is a bulk container. No retrieval possible (normally).
        /// 1/5th of the space required for systems stored here
        /// </summary>
        PackedFull = 5
    }
}