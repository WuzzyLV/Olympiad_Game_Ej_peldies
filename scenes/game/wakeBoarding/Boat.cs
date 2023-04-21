using Godot;
using System;

public class Boat : StaticBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta)
    {
        Vector2 velocity = Vector2.Zero;
        /*if (Input.IsActionPressed("ui_up"))
        {
            velocity.y -= 1;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            velocity.y += 1;
        }*/
        if (Input.IsActionPressed("ui_left"))
        {
            velocity.x -= 1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            velocity.x += 1;
        }

        velocity.y -= 1;
        Position += velocity.Normalized() * 100 * delta;
        //Position = GetViewport().GetMousePosition();
    }
}
