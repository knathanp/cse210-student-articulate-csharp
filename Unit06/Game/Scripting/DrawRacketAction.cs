using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawRacketAction : Action
    {
        private VideoService _videoService;
        
        public DrawRacketAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);

            if (racket.IsDebug())
            {
                Rectangle rectangle = racket.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Animation animation = racket.GetAnimation();
            Image image = animation.NextImage();
            Point position = racket.GetPosition();
            _videoService.DrawImage(image, position);
        }
    }
}