using Godot;
using System;

public class PickUp : Area2D
{

    bool colliding = false;

    public void _on_Area2D_body_entered(Node body)
    {
        colliding = true;
    }
    public void _on_Area2D_body_exited(Node body)
    {
        colliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        Player player = GetNode<Player>("../Player");
        
        if (!player.picked)
        {
            if (colliding)
            {
                if (Input.IsActionJustPressed("ui_pickup"))
                {
                    QueueFree();
                    player.picked = true;
                }
            }
        }

       
    }
}
