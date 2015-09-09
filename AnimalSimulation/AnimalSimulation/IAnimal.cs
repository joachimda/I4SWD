namespace AnimalSimulation
{
    /// <summary>
    /// Does not implement the currentlocation,
    /// should be changed through Move func.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Name of the animal (e.g. "Elephant").
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// State of the animal, if its dead or alive.
        /// </summary>
        bool IsAlive { get; set; }
        
        /// <summary>
        /// Energy level of the animal, 100% = doing well, 0% = dead.
        /// </summary>
        int Energy { get; set; }

        /// <summary>
        /// The weight of the animal in kilograms.
        /// </summary>
        int Weight { get; set; }

        /// <summary>
        /// Moves the animal in a random direction.
        /// </summary>
        /// <returns>Returns -1 on error and 1 on success.</returns>
        int Move();
    }
}