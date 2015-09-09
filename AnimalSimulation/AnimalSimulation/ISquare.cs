namespace AnimalSimulation
{
    /// <summary>
    /// One "field" in the larger "grid" on which animals
    /// will find food.
    /// </summary>
    public interface ISquare
    {
        /// <summary>
        /// The amount of food on the square
        /// </summary>
        int FoodAmount { get; set; }

        /// <summary>
        /// Allows animal to "request" to eat some of the food.
        /// If the requested amount is available, the function will
        /// return 0. If the requested amount isn't present the function
        /// will return the available amount.
        /// </summary>
        /// 
        /// <param name="amountToEat">
        /// The amount the animal wants to eat
        /// </param>
        /// 
        /// <returns>
        /// Returns 0 if the requested amount is less than the 
        /// remaining amount of food.
        /// Returns positive integer if the requested amount of 
        /// food is more/bigger than the available amount. The 
        /// return value will than be the actual available amount, 
        /// which can be eaten.
        /// </returns>
        int Eat(int amountToEat);

        /// <summary>
        /// Function to be called when an aminal wants to be listed 
        /// as "on/in" the square.
        /// </summary>
        /// <param name="enteringAnimal">The entering animal.</param>
        /// <returns>Return positive int on succes, negative if fail.</returns>
        int Enter(IAnimal enteringAnimal);

        /// <summary>
        /// Animal must call this function when leaving square, in order
        /// to be removed from the list of animals on the square.
        /// </summary>
        /// <param name="exitingAnimal">The animal the want to exit.</param>
        /// <returns>Return positive int on succes, negative if fail.</returns>
        int Exit(IAnimal exitingAnimal);
    }
}