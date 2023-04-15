using Godot;
using System;

public class GameScene : Node2D
{ 

    public override void _Ready()
    {
       GD.Print(GetPath());
    }


}
