using Godot;
using System;

public class Score : RichTextLabel
{


   public override void _PhysicsProcess(float delta)
    {
        Player player = GetNode<Player>("/root/MainScene/Player");
        Text = "Score: " + player.score;
        
    }
    
    
}
