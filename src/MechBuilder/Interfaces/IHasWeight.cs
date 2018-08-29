namespace MechBuilder.Interfaces {
    interface IHasWeight {
        /// <summary>
        /// This is how a system will define if it takes up spaces, and how many it provides or occupies.
        /// </summary>
        double Weight { get; set; }
    }
}
