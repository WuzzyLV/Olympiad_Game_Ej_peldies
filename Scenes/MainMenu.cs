using Godot;
using System;

public class MainMenu : Control
{ 

    public void _on_Start_pressed()
    {
        GetTree().ChangeScene("res://Scenes/GameScene.tscn");
    }

    public void _on_Rules_pressed()
    {
        GetTree().ChangeScene("res://Scenes/Rules.tscn");
    }


}
