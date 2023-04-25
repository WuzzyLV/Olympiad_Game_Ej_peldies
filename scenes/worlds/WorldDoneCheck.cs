using Godot;
using System;

public class WorldDoneCheck : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public WorldCompletion.Worlds Worlds;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        if (WorldCompletion.IsWorldComplete(Worlds)) 
            locationDone();
    
    }

    private void locationDone()
    {
        GetTree().ChangeScene("res://scenes/menus/MapScene.tscn");
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
