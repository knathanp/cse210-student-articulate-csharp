using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlRacketAction : Action
    {
        private KeyboardService _keyboardService;
        private bool did_jump = true;

        public ControlRacketAction(KeyboardService keyboardService)
        {
            _keyboardService = keyboardService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            if (_keyboardService.IsKeyDown(Constants.LEFT))
            {
                racket.SwingLeft();
            }

            if (_keyboardService.IsKeyDown(Constants.RIGHT))
            {
                racket.SwingRight();
            }

            if (_keyboardService.IsKeyDown(Constants.SPACE))
            {
                // TODO: make this dependenmt on the object touching the ground again (y=MAX_Y) before it can jump again.
                if (did_jump)
                {
                    racket.Jump();
                    did_jump = false;
                }
                else {
                    racket.StopJumping();
                }
            }

            if (_keyboardService.IsKeyUp(Constants.SPACE))
            {
                did_jump = true;
            }

            if (_keyboardService.IsKeyReleased(Constants.LEFT) ||
                _keyboardService.IsKeyReleased(Constants.RIGHT) ||
                _keyboardService.IsKeyReleased(Constants.SPACE)
               )
            {
                racket.StopMoving();
            }

        }
    }
}