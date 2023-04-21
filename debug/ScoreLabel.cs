using Godot;
using System;

public class ScoreLabel : Label
{
   
    public override void _Ready()
    {
    }

    public override void _Process(float delta)
    {
        Text = "Score: " + Score.GetScore();
    }
}
