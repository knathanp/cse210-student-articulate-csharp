namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _size;
        protected Point _velocity;
        private bool _debug;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor(bool debug)
        {
            _debug = debug;
        }

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor(Point position, Point size, Point velocity, bool debug)
        {
            _position = position;
            _size = size;
            _velocity = velocity;
            _debug = debug;
        }

        /// <summary>
        /// Whether or not the actor is being debugged.
        /// </summary>
        /// <returns>True if being debugged; false if othewise.</returns>
        public bool IsDebug()
        {
            return _debug;
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity. Will wrap the position 
        /// from one side of the screen to the other when it reaches the maximum x and y 
        /// values.
        /// </summary>
        public virtual void MoveNext()
        {
            int x = ((_position.GetX() + _velocity.GetX()) + Constants.SCREEN_WIDTH) % Constants.SCREEN_WIDTH;
            int y = ((_position.GetY() + _velocity.GetY()) + Constants.SCREEN_HEIGHT) % Constants.SCREEN_HEIGHT;
            _position = new Point(x, y);
        }

        /// <summary>
        /// Moves the actor to its next position according to its velocity, with gravity included.
        /// </summary>
        public virtual void MoveNext(int gravity)
        {
            int x = ((_position.GetX() + _velocity.GetX()) + Constants.SCREEN_WIDTH) % Constants.SCREEN_WIDTH;
            int y = ((_position.GetY() + _velocity.GetY() + gravity));
            if (y >= Constants.SCREEN_HEIGHT - _size.GetY()) {
                y = Constants.SCREEN_HEIGHT - _size.GetY();
            }

            _position = new Point(x, y);
        }



        /// <summary>
        /// Gets the position.
        /// </summary>
        /// <returns>The position.</returns>
        public Point GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Gets a rectangle enclosing this body.
        /// </summary>
        /// <returns>The enclosing rectangle.</returns>
        public Rectangle GetRectangle()
        {
            return new Rectangle(_position, _size);
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>The size.</returns>
        public Point GetSize()
        {
            return _size;
        }

        /// <summary>
        /// Gets the velocity.
        /// </summary>
        /// <returns>The velocity.</returns>
        public Point GetVelocity()
        {
            return _velocity;
        }

        /// <summary>
        /// Sets the position to the given value.
        /// </summary>
        /// <param name="position">The given position.</param>
        public void SetPosition(Point position)
        {
            _position = position;
        }

        /// <summary>
        /// Sets the size to the given value.
        /// </summary>
        /// <param name="size">The given size.</param>
        public void SetSize(Point size)
        {
            _size = size;
        }

        /// <summary>
        /// Sets the velocity to the given value.
        /// </summary>
        /// <param name="velocity">The given velocity.</param>
        public void SetVelocity(Point velocity)
        {
            _velocity = velocity;
        }
    }
}