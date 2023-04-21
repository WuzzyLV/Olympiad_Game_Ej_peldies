using Godot;
using System;
using System.Reflection.Emit;

public class Pickup : Godot.Label
{
    float time = 1f, counter = 1;
   
  
    public override void _Process(float delta)
    {


        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        
        if(!g.plastic && !g.paper && !g.glass && !g.dropped)
        {
            Text = "";
            time = 1f;
            counter = 1f;
        }

        if (g.plastic)
        {
            Text = "+1 Plastic";
            time -= delta;
        }
        if (g.paper)
        {
            Text = "+1 Paper";
            time -= delta;
        }
        if (g.glass)
        {
            Text = "+1 Glass";
            time -= delta;
        }

        GD.Print(g.dropped);

        if(g.dropped)
        {
            Text = "-1 Item";
            time -= delta;
            counter -= delta;
            if (counter <= 0 || g.picked)
            {
                g.dropped = false;
            }
        }
      
        GD.Print(time);

        if (time <= 0)
        { 
            Text = "";
            if (g.plastic)
                return;
            if (g.paper)
                return;
            if (g.glass)
                return;
            
            time = 1;
        }
    }
    
}
