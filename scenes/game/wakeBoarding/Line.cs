using Godot;
using System;

public class Line : Line2D
{
    Boat boat;
    Sprite yes;
   /* public override void _Ready()
    {
        boat = GetNode<Boat>("/root/Player/Boat2");
        yes = GetNode<Sprite>("/root/Player/Yes/Sprite");
        *//* Points = new Vector2[] { boat.Position, yes.Position };
         DefaultColor = Colors.Red;
         Width = 3;*//*


    }

    public override void _PhysicsProcess(float delta)
    {
     
    
        Vector2[] points = { boat.Position, yes.Position };
        Points = points;

       
        float distance = boat.Position.DistanceTo(yes.Position);
         
        if (distance > 0)
        {
            Vector2 direction = (yes.Position - boat.Position).Normalized();
            yes.Position = boat.Position + direction * distance;
        }

    }*/
   

}
