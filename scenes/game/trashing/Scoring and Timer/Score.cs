using Godot;
using System;

public class Scoring : RichTextLabel
{


   public override void _PhysicsProcess(float delta)
    {
        Score score = GetNode<Score>("res://src/Score");
        
    }
    
    
}
