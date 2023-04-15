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
        Player player = GetNode<Player>("../Player");
        
        if(colliding)
        {
            if (player.picked)
            {
                if (Input.IsActionJustPressed("ui_drop"))
                {
                    player.picked = false;
                    player.score++;
                }
            }
        }

    }
}
