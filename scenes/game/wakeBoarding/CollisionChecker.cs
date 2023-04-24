using Godot;
using System;

public class CollisionChecker : Area2D
{
    public void _on_Area2D_body_entered(Node body)
    { 
        if(body.Name != "Boat" && body.Name != "WakeBoard" && body.Name != "Border_Right" && body.Name != "Border_Left" &&  body.Name != "Border_Up" && body.Name != "Border_Down")
        {

            GetTree().ChangeScene("res://scenes/game/trashing/Scenes/GameOverScreen.tscn");
        }
    }
}
