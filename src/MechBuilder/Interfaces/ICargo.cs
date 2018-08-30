using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder
{
    /// <summary>
    /// Dedicated cargo space that does NOT enable use of the modules stored here.
    /// However they're stored at a more efficient rate
    /// </summary>
    public interface ICargo : IStorage {
        /// <summary>
        /// 
        /// </summary>
        int Efficiency { get; set; }
    }
}