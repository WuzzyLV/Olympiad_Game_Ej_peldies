using Godot;
using System;

public class Wakeboard : RigidBody2D
{

    [Export]
    public float PullForce = 10;
    public override void _PhysicsProcess(float delta)
    {
       
    }

    public override void _IntegrateForces(Physics2DDirectBodyState state)
    {
        Vector2 vel = state.LinearVelocity;
        vel.y = PullForce;
        state.LinearVelocity = vel;
        //cancel spin
        Rotation = 0;
    }
}
