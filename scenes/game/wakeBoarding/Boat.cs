using Godot;
using System;

public class Boat : KinematicBody2D
{
   
    [Export]
    public float Speed = 80;
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(float delta)
    {
        Vector2 velocity = Vector2.Zero;
       /* if (Input.IsActionPressed("ui_up"))
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
        
        //velocity.y -= 1;
       // velocity = velocity.Normalized();
      
        //velocity.x *= 500;
        MoveAndSlide(velocity.Normalized() * Speed);
        //Position = GetViewport().GetMousePosition();
      
       
    }

    
}
