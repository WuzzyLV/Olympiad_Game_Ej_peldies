using Godot;
using System;

public class ActivateGame : Area2D
{

    bool colliding = false;

    public void _on_MiniGame_body_entered(Node body)
    {
        colliding = true;
    }

    public void _on_MiniGame_body_exited(Node body)
    {
        colliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        if (!colliding)
            return;
        if (!Input.IsActionJustPressed("interact"))
            return;

        GetTree().ChangeScene("res://scenes/game/WakeBoardingScene.tscn");

    }
}
