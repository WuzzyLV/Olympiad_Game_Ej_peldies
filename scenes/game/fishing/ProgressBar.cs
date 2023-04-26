using Godot;
using System;

public class ProgressBar : Godot.ProgressBar
{
    
    [Export] public float AddedAmount = 1f;
    [Export] public float DivideValue = 2;
    [Export] public int winScore = 100;
    
    private MiddleMenu middleMenu;
    private bool isColliding = false;
    private int score = 0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        middleMenu= GetNode<MiddleMenu>("../MiddleMenu");
        Value = MaxValue / 2;
    }

    public override void _Process(float delta)
    {
        if (isColliding)
        {
            Value += AddedAmount*delta;
        }
        else
        {
            Value -= AddedAmount*delta;
        }
        
        //check if full or emptpty
        if (Value >= MaxValue)
        {
            score = winScore;
        }
        else if (Value <= 0)
        {
            score = 0;
        }
        else
        {
            return;
        }
        middleMenu.setScore(score);
        PlayerProgress.TaskFinished(PlayerProgress.LastTask);
        middleMenu.show();
    }

    public void _on_Area2D_area_entered(Area2D area)
    {
        isColliding = true;
    }
    public void _on_Area2D_area_exited(Area2D area)
    {
        isColliding = false;
    }
}
