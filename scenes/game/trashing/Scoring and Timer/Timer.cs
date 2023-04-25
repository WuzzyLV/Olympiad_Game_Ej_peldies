using Godot;
using System;

public class Timer : RichTextLabel
{

    [Export]public float timeElapsed = 10f;
    private int minutes;
    private int seconds;
    private int milliseconds;
    private string timeString;
    TrashGameGlobal g;
    public override void _Ready()
    {
        g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
    }
    public override void _Process(float delta)
    { 
        
        timeElapsed -= delta;
        minutes = Mathf.FloorToInt(timeElapsed / 60);
        seconds = Mathf.FloorToInt(timeElapsed % 60);
        milliseconds = Mathf.FloorToInt((timeElapsed % 1) * 100);
        timeString = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
        Text = timeString;
       
       
        if (timeElapsed <= 0)
        {
            GD.Print("Game Over");
            GD.Print(g.score);
            Score.AddScore(g.score);
            GetTree().ChangeScene(PlayerProgress.LastScene);
            PlayerProgress.TaskFinished(PlayerProgress.Tasks.TrashPludmale);
        }
       
    }
            
    
}

