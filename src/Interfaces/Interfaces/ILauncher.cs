using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API
{
    /// <summary>
    /// The sole advantage of this sytem is it launches mecha at a high speed, saving on fuel for the mecha.
    /// Need one system per mecha that can be launched at a time
    /// The size of this system determines how big a mecha can be stored or retrieved at any time.
    /// </summary>
    public interface ILauncher : IStorage
    {
        /// <summary>
        /// Where all the mecha that use this system get stored
        /// </summary>
        IHangar Hangar { get; set; }
    }
}