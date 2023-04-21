using Godot;
using System;

public class GlassPickUp : Area2D
{
    bool colliding = false;

    public void _on_Glass_body_entered(Node body)
    {
        colliding = true;
       
        
    }
    public void _on_Glass_body_exited(Node body)
    {
        colliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        ItemSpawner itemSpawner = GetNode<ItemSpawner>("/root/GameScene/Area2D/ItemSpawner");

        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");

        if (g.picked)
        {
            return;
        }
        if (!colliding)
        {
            return;
        }
        if (!Input.IsActionJustPressed("ui_pickup"))
        {
            return;
        }
        QueueFree();
        g.picked = true;
        g.glass = true;
        itemSpawner.count -= 1;
    }
}
