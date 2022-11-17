using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveBallAction : Action
    {
        public MoveBallAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Ball ball = (Ball)cast.GetFirstActor(Constants.BALL_GROUP);
            Point position = ball.GetPosition();
            Point velocity = ball.GetVelocity();
            position = position.Add(velocity);
            ball.SetPosition(position);
        }
    }
}