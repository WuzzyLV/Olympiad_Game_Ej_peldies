using Godot;
using System;

public class testSpring : DampedSpringJoint2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        this.Stiffness = 0.1f;   
    }

    public override void _PhysicsProcess(float delta)
    {
    }
}
