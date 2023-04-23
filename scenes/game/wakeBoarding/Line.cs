using Godot;
using System;

public class Line : Line2D
{
    Boat boat;
    Yes yes;
    public override void _Ready()
    {
        boat = GetNode<Boat>("/root/Node2D/Player/Boat");
        yes = GetNode<Yes>("/root/Node2D/Player/WakeBoard");
        Points = new Vector2[] { boat.Position, yes.Position };
         DefaultColor = Colors.Black;
         Width = 1;


    }

    public override void _PhysicsProcess(float delta)
    {
     
    
        Vector2[] points = { boat.Position, yes.Position };
        Points = points;


    }
   

}
