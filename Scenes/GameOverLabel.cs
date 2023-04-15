using Godot;
using System;

public class GameOverLabel : RichTextLabel
{


    public override void _Ready()
    {

       Global g = GetNode<Global>("/root/Global");
        Text = "Game ended!\nScore: " + g.score;
        
    }

   
}
