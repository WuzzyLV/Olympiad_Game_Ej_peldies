using Godot;
using System;

public class MainMenu : Control
{
    public void _on_Start_pressed()
    {
        GetTree().ChangeScene("res://scenes/MainScene.tscn");
    }

    public void _on_About_game_pressed()
    {
        GetTree().ChangeScene("res://scenes/game/AboutGame.tscn");
    }


    public void _on_Quit_pressed()
    { 
    GetTree().Quit();
    }



}
