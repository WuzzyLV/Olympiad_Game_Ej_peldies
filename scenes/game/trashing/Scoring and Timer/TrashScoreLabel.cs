using Godot;
using System;

public class TrashScoreLabel : Godot.Label
{

    public override void _Ready()
    {
        Text = "Punkti: 0";
    }
    public override void _PhysicsProcess(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        Text = "Punkti: " + g.score;
        
    }

    
    
    
}
