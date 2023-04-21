using Godot;
using System;

public class GameOverScreen : Control
{
    public void _on_Restart_pressed() 
    {
        GetTree().ChangeScene("res://scenes/game/TrashScene.tscn");
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        g.score = 0;
        g.plastic = false;
        g.paper = false;
        g.glass = false;
        g.dropped = false;
        g.picked = false;
    }
}
