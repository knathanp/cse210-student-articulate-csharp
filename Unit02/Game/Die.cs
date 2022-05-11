using System;


namespace Unit02.Game
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of its currently rolled value and the points its
    /// worth.
    /// </summary> 
    public class Die
    {

        public int value;
        public int points;

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
            value = 0;
            points = 0;
        }

        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        public void Roll()
        {
            Random random = new Random();
            value = random.Next(1, 7); // roll dice by selecting a number 1-6
            
            if (value == 5)
                points = 50;
            else if (value == 1)
                points = 100;
            else
                points = 0;
        }
    }
}