using Godot;
using System;

public class PlasticTrashCan : Area2D
{

    bool colliding = false;
    public void _on_PlasticCan_body_entered(Node body)
    {
        colliding = true;
        GD.Print("Enter plastic!");
    }

    public void _on_PlasticCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit! plastic ");
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
        if (Input.IsActionJustPressed("interact") && !g.plastic && g.picked)
        {
            g.dropped = true;
            g.picked = false;
            Score.AddScore(-1);
            g.paper = false; g.glass = false;
            g.score--;
            return;
        }
        g.picked = false;
        g.plastic = false;
        Score.AddScore(1);
        g.score++;
        g.dropped = true;
    }
}
