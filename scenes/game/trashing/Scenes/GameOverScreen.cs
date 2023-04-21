using Godot;
using System;

public class GameOverScreen : Control
{
    public void _on_Restart_pressed() 
    {
        GetTree().ChangeScene("res://scenes/game/GameScene.tscn");
        Global g = GetNode<Global>("/root/Global");
        g.score = 0;
        g.plastic = false;
        g.paper = false;
        g.glass = false;
        g.dropped = false;
        g.picked = false;
    }
}
