using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawRacketAction : Action
    {
        private VideoService videoService;
        
        public DrawRacketAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Racket racket = (Racket)cast.GetFirstActor(Constants.RACKET_GROUP);
            Body body = racket.GetBody();

            if (racket.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Animation animation = racket.GetAnimation();
            Image image = animation.NextImage();
            Point position = body.GetPosition();
            videoService.DrawImage(image, position);

            Racket racket2 = (Racket)cast.GetActors(Constants.RACKET_GROUP)[1];
            Body body2 = racket2.GetBody();

            Animation animation2 = racket2.GetAnimation();
            Image image2 = animation2.NextImage();
            Point position2 = body2.GetPosition();
            videoService.DrawImage(image2, position2);

        }
    }
}