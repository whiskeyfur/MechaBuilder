﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IRangedWeapon : IWeapon {
        /// <summary>
        /// 
        /// </summary>
        int Range { get; set; }
    }
}