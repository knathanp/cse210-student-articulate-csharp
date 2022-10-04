using System;


namespace Unit02.Game
{
    public class Die
    {
        public int value;
        public int points;

        public Die() 
        {
            Roll();
        }

        public void Roll()
        {

            Random r = new Random();
            value = r.Next(1, 7);
            points = (value == 1) ? 100 : (value == 5) ? 50 : 0;
        }
    }
        
}