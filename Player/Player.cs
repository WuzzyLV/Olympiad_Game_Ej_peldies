using Godot;
using System;

public class Player : KinematicBody2D
{

    const float speed = 250;
    
    public void move()
    {
        Vector2 inputDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        var Velocity = inputDirection * speed;

        MoveAndSlide(Velocity);
    }

    public override void _PhysicsProcess(float delta)
    {
        move();
    }
}
