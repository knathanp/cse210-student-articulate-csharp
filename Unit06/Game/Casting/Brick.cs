namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Brick : Actor
    {
        private Animation _animation;
        private int _points;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Brick(Animation animation, int points, Point position, Point size, Point velocity, bool debug) 
        : base(position, size, velocity, debug)
        {
            _animation = animation;
            _points = points;
        }

        /// <summary>
        /// Gets the animation.
        /// </summary>
        /// <returns>The animation.</returns>
        public Animation GetAnimation()
        {
            return _animation;
        }

        /// <summary>
        /// Gets the points.
        /// </summary>
        /// <returns>The points.</returns>
        public int GetPoints()
        {
            return _points;
        }
        
    }
}