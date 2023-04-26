using Godot;
using System;

public class Rock : KinematicBody2D
{
    private float speed = 75;
    
    ObjectSpawner objectSpawner;

    public override void _Ready()
    {
        objectSpawner = GetParent<ObjectSpawner>();
    }

    public override void _PhysicsProcess(float delta)
    {

        Vector2 velocity = Vector2.Zero;
        
        
        velocity.y += 1;
        velocity = velocity.Normalized();


        float speedAfter= speed+(0.1f*objectSpawner.time);
        MoveAndSlide(velocity * speedAfter);

    }
}
