using Godot;
using System;

public class ProgressBar : Godot.ProgressBar
{
    private bool isColliding = false;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        if (isColliding)
        {
            Value += 0.1f;
        }
        else
        {
            Value -= 0.1f;
        }
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
