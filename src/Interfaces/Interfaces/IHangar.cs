using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API
{
    /// <summary>
    /// Specialized storage for IMecha
    /// </summary>
    public interface IHangar : IStorage
    {
        /// <summary>
        /// Is there enough space for the proposed mecha?
        /// </summary>
        /// <param name="mecha"></param>
        /// <returns></returns>
        bool CanStore(IMecha mecha);
        /// <summary>
        /// Set the mecha's location to 'here' and put this mecha in the systems inventory as a subsystem
        /// </summary>
        /// <param name="mecha"></param>
        void Store(IMecha mecha);
    }
}