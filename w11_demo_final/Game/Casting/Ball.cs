using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// 
    /// </summary>
    public class Ball : Actor
    {
        private static Random _random = new Random();
        private Image _image;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Ball(Image image, Point position, Point size, Point velocity, bool debug = false) 
        : base(position, size, velocity, debug)
        {
            _image = image;
        }

        /// <summary>
        /// Bounces the ball horizontally.
        /// </summary>
        public void BounceX()
        {
            double rn = (_random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = _velocity.GetX() * -1;
            double vy = _velocity.GetY();
            _velocity = new Point((int)vx, (int)vy);
        }

        /// <summary>
        /// Bounces the ball vertically.
        /// </summary>
        public void BounceY()
        {
            double rn = (_random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = _velocity.GetX();
            double vy = _velocity.GetY() * -1;
            _velocity = new Point((int)vx, (int)vy);
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return _image;
        }

        /// <summary>
        /// Releases ball in random horizontal direction.
        /// </summary>
        public void Release()
        {
            List<int> velocities = new List<int> { Constants.BALL_VELOCITY, Constants.BALL_VELOCITY };
            int index = _random.Next(velocities.Count);
            double vx = velocities[index];
            double vy = -Constants.BALL_VELOCITY;
            _velocity = new Point((int)vx, (int)vy);
        }
    }
}