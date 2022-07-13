using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlRacketAction : Action
    {
        private KeyboardService keyboardService;

        public ControlRacketAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket1 = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            Racket racket2 = (Racket)cast.GetActors(Constants.RACKET_GROUP)[1];

            // Control First Racket
            if (keyboardService.IsKeyDown(Constants.LEFT))
            {
                racket1.SwingLeft();
            }
            else if (keyboardService.IsKeyDown(Constants.RIGHT))
            {
                racket1.SwingRight();
            }
            else if (keyboardService.IsKeyDown(Constants.UP))
            {
                racket1.SwingUp();
            }
            else if (keyboardService.IsKeyDown(Constants.DOWN))
            {
                racket1.SwingDown();
            }

            else
            {
                racket1.StopMoving();
            }

            // Control Second Racket
            if (keyboardService.IsKeyDown(Constants.A))
            {
                racket2.SwingLeft();
            }
            else if (keyboardService.IsKeyDown(Constants.D))
            {
                racket2.SwingRight();
            }
            else if (keyboardService.IsKeyDown(Constants.W))
            {
                racket2.SwingUp();
            }
            else if (keyboardService.IsKeyDown(Constants.S))
            {
                racket2.SwingDown();
            }
            else
            {
                racket2.StopMoving();
            }
        }
    }
}