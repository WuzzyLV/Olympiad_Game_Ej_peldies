using Godot;
using System;

public class GameOverLabel : RichTextLabel
{


    public override void _Ready()
    {

        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        Text = "Game ended!\nScore: " + g.score;
        
    }

   
}
