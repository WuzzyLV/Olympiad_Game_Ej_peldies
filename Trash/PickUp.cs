using Godot;
using System;

public class PickUp : Area2D
{

    bool picked = false;

    public void _on_Area2D_body_entered(Node body)
    {
        picked = true;
    }
    public void _on_Area2D_body_exited(Node body)
    {
        picked = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        Player player = GetNode<Player>("../Player");
        
        if (!player.picked)
        {
            if (picked)
            {
                if (Input.IsActionJustPressed("ui_pickup"))
                {
                    QueueFree();
                    player.picked = true;
                }
            }
        }

        if (Input.IsActionJustPressed("ui_drop"))
        {
            player.picked = false;
        }
    }
}
