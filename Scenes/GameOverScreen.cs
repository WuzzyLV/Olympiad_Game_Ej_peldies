using Godot;
using System;

public class GameOverScreen : Control
{
    public void _on_Restart_pressed() 
    {
        GetTree().ChangeScene("res://Scenes/GameScene.tscn");
        Global g = GetNode<Global>("/root/Global");
        g.score = 0;
    }
}
