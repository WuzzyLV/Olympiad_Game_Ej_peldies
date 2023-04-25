using Godot;
using System;

public class GameScene : Node2D
{ 

    public override void _Ready()
    {
       GD.Print(GetPath());
    }

    public override void _Process(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        //GD.Print(Score.GetScore());
    }


}
