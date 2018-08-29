
namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public interface IMecha : ISystem {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Serial { get; set; }
    }
}
