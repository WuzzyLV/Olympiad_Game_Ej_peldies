using Godot;
using System;

public class CollisionChecker : Area2D
{
    bool isColliding = false;
  
    public void _on_Area2D_body_entered(Node body)
    {
       isColliding = true;
    }

    public void _on_Area2D_body_exited(Node body)
    {
       isColliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        if (isColliding)
        {
            if (Input.IsActionJustPressed("ui_accept"))
            {
            GD.Print("Enter!");
            }
        }
    }

}
