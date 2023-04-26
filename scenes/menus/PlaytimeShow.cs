using Godot;
using System;
using System.Net.Mime;

public class PlaytimeShow : Label
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Text="Spēlē pavadītais laiks: "+Playtime.GetPlaytimeString();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
