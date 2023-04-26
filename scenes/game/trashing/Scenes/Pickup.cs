using Godot;
using System;
using System.Reflection.Emit;

public class Pickup : Godot.Label
{
    float time = 1f, counter = 1;
   
    float lastScore = 0;
    
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
            Text = "+1 Plastmass";
            time -= delta;
        }
        if (g.paper)
        {
            Text = "+1 Papīrs";
            time -= delta;
        }
        if (g.glass)
        {
            Text = "+1 Stikls";
            time -= delta;
        }

        

        if(g.dropped)
        {
            String s = "";
            if (g.score>lastScore)
                s = "+10";
            else
                s = "-10";
            
            Text = s + " Punkti";
            time -= delta;
            counter -= delta;
            if (counter <= 0 || g.picked)
            {
                g.dropped = false;
            }
        }
      
        

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
