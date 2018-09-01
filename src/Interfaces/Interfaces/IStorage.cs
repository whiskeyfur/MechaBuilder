using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// Unspecialized storage, can hold anything, but no efficiency for doing so.
    /// </summary>
    public interface IStorage : ISystem {
        /// <summary>
        /// Can this storage place store the new System?
        /// </summary>
        /// <param name="System">Prospective system to store</param>
        void CanStore(ISystem System);
    }
}