using System;

public class Youtuber : Creator
{
    public override void Create()
    {
        if (base.CreativityLevel >= 50 && base.Energy >= 60)
        {
            this.BrainstormingIdeas();
            this.CreateScript();
            this.VideoTapeScript();
            this.EditingVideo();
            this.RenderingVideo();
        }
        else {
            throw new Exception("Not enough creativity or energy to create a video");
        }
    }

    private void BrainstormingIdeas() {
        base.CreativityLevel -= 5;
        base.Energy -= 5;
        Console.WriteLine("Brainstorming Ideas...");
    }

    private void CreateScript() {
        base.CreativityLevel -= 5;
        base.Energy -= 5;
        Console.WriteLine("Creating a video script...");
    }


    private void VideoTapeScript() {
        base.CreativityLevel -= 1;
        base.Energy -= 10;
        Console.WriteLine("Videotaping myself executing the script...");
    }

    private void EditingVideo() {
        base.CreativityLevel -= 5;
        base.Energy -= 5;
        Console.WriteLine("Editing the video...");
    }

    private void RenderingVideo() {
        base.CreativityLevel -= 1;
        base.Energy -= 1;
        Console.WriteLine("Rendering the video...");
    }
}