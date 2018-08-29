namespace MechBuilder.Interfaces {
    /// <summary>
    /// 
    /// </summary>
    public interface IHasCost {
        /// <summary>
        /// This is how a system will define if it costs construction points, and how many cp points it costs.
        /// </summary>
        double Cost { get; set; }
    }
}
