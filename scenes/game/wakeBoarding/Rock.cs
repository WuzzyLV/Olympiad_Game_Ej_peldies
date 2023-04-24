using Godot;
using System;

public class Rock : KinematicBody2D
{
    private int speed = 75;
    public override void _PhysicsProcess(float delta)
    {

        Vector2 velocity = Vector2.Zero;

        velocity.y += 1;
        velocity = velocity.Normalized();


        MoveAndSlide(velocity * speed);

    }
}
