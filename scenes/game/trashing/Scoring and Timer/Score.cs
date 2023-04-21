using Godot;
using System;

public class Score : RichTextLabel
{


   public override void _PhysicsProcess(float delta)
    {
        Global g = GetNode<Global>("/root/Global");
        Text = "Score: " + g.score;

    }
    
    
}
