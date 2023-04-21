using Godot;
using System;

public class Rules : Control
{
  
    public void _on_Back_pressed()
    {
        GetTree().ChangeScene("res://Scenes/MainMenu.tscn");
    }
}
