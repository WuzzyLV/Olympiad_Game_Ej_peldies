using Godot;
using System;

public class TrashScoreLabel : RichTextLabel
{

    public override void _Ready()
    {
        Text = "asdasd";
    }
    public override void _PhysicsProcess(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        Text = "Punkti: " + g.score;
        
    }

    
    
    
}
