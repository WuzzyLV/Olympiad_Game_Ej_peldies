using Godot;
using System;

public class CanInteract : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public PlayerProgress.Tasks Task;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        if (PlayerProgress.IsTaskCompleted(Task))
        {
            Visible = false;
        }
        else
        {
            Visible = true;
        }
    }

}
