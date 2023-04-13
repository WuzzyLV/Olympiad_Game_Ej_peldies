using Godot;
using System;

public class PickUp : Area2D
{

    bool colliding = false;

    public void _on_Trash_body_entered(Node body)
    {
        colliding = true;
    }
    public void _on_Trash_body_exited(Node body)
    {
        colliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        ItemSpawner itemSpawner = GetNode<ItemSpawner>("/root/MainScene/Area2D/ItemSpawner");
        
        Player player = GetNode<Player>("/root/MainScene/Player");

        if (!player.picked)
        {
            if (colliding)
            {
                if (Input.IsActionJustPressed("ui_pickup"))
                {
                    QueueFree();
                    player.picked = true;
                    itemSpawner.count -=1 ;
                }
            }
        }

       
    }
}
