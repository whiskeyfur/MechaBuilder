using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface ISystemCollection : IList<ISystem> {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        double GetTotalCost();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        double GetTotalWeight();
    }
}