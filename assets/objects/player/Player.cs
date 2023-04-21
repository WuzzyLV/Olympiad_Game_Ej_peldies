using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public class Player : KinematicBody2D
{

    [Export] public float Speed = 150;

    private AnimationTree _tree;

    public override void _Ready()
    {
        _tree = GetNode<AnimationTree>("AnimationTree");
    }

    public override void _PhysicsProcess(float delta)
    {
        Vector2 velocity = Vector2.Zero;
        
        if (Input.IsActionPressed("ui_up"))
        {
            velocity.y -= 1;
        }
        if (Input.IsActionPressed("ui_down"))
        {
            velocity.y += 1;
        }
        if (Input.IsActionPressed("ui_left"))
        {
            velocity.x -= 1;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            velocity.x += 1;
        }

       
        if (velocity == Vector2.Zero)
        {
            AnimationNodeStateMachinePlayback stateMachinePlayback = (AnimationNodeStateMachinePlayback) _tree.Get("parameters/playback");
            stateMachinePlayback.Travel("Idle");
        }
        else
        {
            AnimationNodeStateMachinePlayback stateMachinePlayback = (AnimationNodeStateMachinePlayback) _tree.Get("parameters/playback");
            stateMachinePlayback.Travel("Walk");
            _tree.Set("parameters/Idle/blend_position", velocity);
            _tree.Set("parameters/Walk/blend_position", velocity);
            MoveAndSlide(velocity.Normalized() * Speed);
        }

    }
}
