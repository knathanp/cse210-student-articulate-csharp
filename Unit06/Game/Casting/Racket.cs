namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Racket : Actor
    {
        private Animation _animation;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Racket(Animation animation, Point position, Point size, Point velocity, bool debug)
        : base(position, size, velocity, debug)
        {
            _animation = animation;
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
        /// Moves the racket to its next position.
        /// </summary>
        public void MoveNext()
        {
            Point newPosition = _position.Add(_velocity);
            SetPosition(newPosition);
        }

        /// <summary>
        /// Swings the racket to the left.
        /// </summary>
        public void SwingLeft()
        {
            _velocity = new Point(-Constants.RACKET_VELOCITY, 0);
        }

        /// <summary>
        /// Swings the racket to the right.
        /// </summary>
        public void SwingRight()
        {
            _velocity = new Point(Constants.RACKET_VELOCITY, 0);
        }

        /// <summary>
        /// Stops the racket from moving.
        /// </summary>
        public void StopMoving()
        {
            _velocity = new Point(0, 0);
        }

    }
}