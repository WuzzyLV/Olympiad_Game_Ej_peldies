using Godot;
using System;

public class PaperTrashCan : Area2D
{
    bool colliding = false;
    public void _on_PaperCan_body_entered(Node body)
    {
        colliding = true;
        GD.Print("Enter paper!");
    }

    public void _on_PaperCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit! paper ");
    }

    public override void _PhysicsProcess(float delta)
    {
        Global g = GetNode<Global>("/root/Global");

        if (!g.paper)
        {
            return;
        }
        if (!colliding)
        {
            return;
        }
        if (!Input.IsActionJustPressed("ui_drop"))

        {
            return;
        }
        g.picked = false;
        g.paper = false;
        g.score++;
    }
}
