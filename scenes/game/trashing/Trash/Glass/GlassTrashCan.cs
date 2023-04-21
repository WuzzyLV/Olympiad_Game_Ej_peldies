using Godot;
using System;

public class GlassTrashCan : Area2D
{

    bool colliding = false;
    public void _on_GlassCan_body_entered(Node body)
    {
        colliding = true;
        GD.Print("Enter glass!");
    }

    public void _on_GlassCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit! glass ");
    }

    public override void _PhysicsProcess(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");

        if (!g.picked)
        {
            return;
        }
        if (!colliding)
        {
            return;
        }
        if (!Input.IsActionJustPressed("interact"))

        {
            return;
        }
        if (Input.IsActionJustPressed("interact") && !g.glass && g.picked)
        {
            g.dropped = true;
            g.picked = false;
            g.score--;
            g.plastic = false; g.paper = false;
            return;
        }
        g.picked = false;
        g.glass = false;
        g.score++;
        g.dropped = true;
    }
}
