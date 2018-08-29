using System.Windows.Forms;

namespace MechBuilder.Interfaces {
    interface IMecha {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Serial { get; set; }

        /// <summary>
        /// This SHOULD be a singleton to prevent conflicting forms all accessing the same instance
        /// </summary>
        Form Form { get; }
    }
}
