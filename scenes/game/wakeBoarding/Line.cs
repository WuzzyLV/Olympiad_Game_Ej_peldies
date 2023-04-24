using Godot;
using System;

public class Line : Line2D
{
    Boat boat;
    Wakeboard wakeboard;
    public override void _Ready()
    {
        boat = GetNode<Boat>("/root/Node2D/Player/Boat");
        wakeboard = GetNode<Wakeboard>("/root/Node2D/Player/WakeBoard");
        Points = new Vector2[] { boat.Position, wakeboard.Position };
         DefaultColor = Colors.Black;
         Width = 1;


    }

    public override void _PhysicsProcess(float delta)
    {
     
    
        Vector2[] points = { boat.Position, wakeboard.Position };
        Points = points;


    }
   

}
