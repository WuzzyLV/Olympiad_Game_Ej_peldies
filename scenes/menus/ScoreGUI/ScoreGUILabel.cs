using Godot;
using System;

public class ScoreGUILabel : Label
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public String text = "Punkti: ";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Text = text + Score.GetScore();
    }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      Text = text + Score.GetScore();
  }
}
