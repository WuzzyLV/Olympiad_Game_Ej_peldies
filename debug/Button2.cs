using Godot;
using System;

public class Button2 : Button
{
    public void _on_Button2_pressed()
    {
        GetTree().ChangeScene("res://scenes/game/TrashScene.tscn");
    }
}
