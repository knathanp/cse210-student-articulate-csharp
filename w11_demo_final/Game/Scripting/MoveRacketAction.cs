using Unit06.Game.Casting;
using Unit06;

namespace Unit06.Game.Scripting
{
    public class MoveRacketAction : Action
    {
        public MoveRacketAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            racket.MoveNext(Constants.GRAVITY);
        }
    }
}