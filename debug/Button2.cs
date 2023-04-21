using Godot;
using System;

public class Button2 : Button
{
    public void _on_Button_pressed()
    {
        GetTree().ChangeScene("res://scenes/game/GameScene.tscn");
    }
}
