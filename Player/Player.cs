using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public class Player : KinematicBody2D
{

    const float speed = 150;


    public override void _PhysicsProcess(float delta)
    {
        AnimationTree tree = GetNode<AnimationTree>("/root/GameScene/player/AnimationTree");
        var Velocity = Vector2.Zero;

        if (Input.IsActionPressed("ui_up"))
        {
            Velocity.y -= 1;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            Velocity.y += 1;
        }
        if (Input.IsActionPressed("ui_left"))
        {
            Velocity.x -= 1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            Velocity.x += 1;
        }

       
        if (Velocity == Vector2.Zero)
        {
            AnimationNodeStateMachinePlayback stateMachinePlayback = (AnimationNodeStateMachinePlayback)tree.Get("parameters/playback");
            stateMachinePlayback.Travel("Idle");
        }
        else
        {
            AnimationNodeStateMachinePlayback stateMachinePlayback = (AnimationNodeStateMachinePlayback)tree.Get("parameters/playback");
            stateMachinePlayback.Travel("Walk");
            tree.Set("parameters/Idle/blend_position", Velocity);
            tree.Set("parameters/Walk/blend_position", Velocity);
            MoveAndSlide(Velocity.Normalized() * speed);
        }

    }
}
