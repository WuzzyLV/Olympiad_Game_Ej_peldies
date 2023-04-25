using Godot;
using System;

public class CollisionChecker : Area2D
{

    private MiddleMenu _middleMenu;
    public override void _Ready()
    {
        _middleMenu = GetNode<MiddleMenu>("/root/Node2D/MiddleMenu");
    }

    public void _on_Area2D_body_entered(Node body)
    { 
        if(body.Name != "Boat" && body.Name != "WakeBoard" && body.Name != "Border_Right" && body.Name != "Border_Left" &&  body.Name != "Border_Up" && body.Name != "Border_Down")
        {
            ObjectSpawner s = GetNode<ObjectSpawner>("/root/Node2D/Node/Timer");
            //TODO improve score system
            int score = (int) s.time;
            Score.AddScore(score);
            
            PlayerProgress.TaskFinished(PlayerProgress.Tasks.BoatGameBeberlini);
            
            _middleMenu.setScore(score);
            _middleMenu.show();
            
        }
    }
}
