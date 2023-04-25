using Godot;
using System;

public class MapSceneRoot : Control
{
    [Export] public String EndPath = "res://scenes/menus/EndGame.tscn";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GetTree().ChangeScene(EndPath);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
