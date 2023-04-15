using Godot;
using System;
using System.Xml.Schema;

public class TrashDrop : Area2D
{
    bool colliding = false;
    public void _on_TrashCan_body_entered(Node body)
    {
      colliding = true;
        GD.Print("Enter!");
    }

    public void _on_TrashCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit!");
    }

    public override void _PhysicsProcess(float delta)
    {
        Global g = GetNode<Global>("/root/Global");
        
        
        if(colliding)
        {
            if (g.picked)
            {
                if (Input.IsActionJustPressed("ui_drop"))
                {
                    g.picked = false;
                    g.score++;
                }
            }
        }

    }
}
