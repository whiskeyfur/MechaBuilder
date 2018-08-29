namespace MechBuilder.Interfaces {
    /// <summary>
    /// 
    /// </summary>
    public interface IHasMultiplier {
        /// <summary>
        /// This is how a system will define if it has a cost multiplier applied to the entire mecha, and the value of the multiplier.
        /// </summary>
        double Multiplier { get; set; }
    }
}
