using Godot;
using System;

public class ScoreInfo : CanvasLayer
{
    public int score;
    public Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Label>("Pause/Label");
    }

    public void setScore(int score)
    {
        this.score = score;
        scoreLabel.Text = "Spēles punktu skaits: " + score;
    }

    public int getScore()
    { 
       return score;
    }
}
