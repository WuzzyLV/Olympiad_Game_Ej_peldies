using Godot;
using System;

public class MiddleMenu : CanvasLayer
{
    [Export] public String LabelMSG = "Spēle beigusies!";
    public int score;
    private Godot.Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Godot.Label>("Pause/Label");
        GetNode<Godot.Label>("Pause/Title").Text= LabelMSG;
    }

    public void setScore(int score)
    {
        scoreLabel.Text = "Spēles punktu skaits: " + score;
    }

    public void show()
    {
        var pauseState = !GetTree().Paused;
        GetTree().Paused = pauseState;
        Visible = pauseState;
    }
    

}
