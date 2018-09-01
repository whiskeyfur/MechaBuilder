
namespace MechBuilder.API {
    /// <summary>
    /// 
    /// </summary>
    public interface IMecha : ISystem {
        /// <summary>
        /// This is the name of the mecha. Or rather, where it gets stored.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Serial { get; set; }
    }
}
