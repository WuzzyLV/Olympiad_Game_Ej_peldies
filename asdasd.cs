using Godot;
using System;

public class asdasd : Godot.Timer
{


    public void _on_Timer_timeout()
    { 
        Pickup anim  = GetNode<Pickup>("/root/GameScene/PickUpStuff/Pickup");
        anim.Text = "";
        Global g = GetNode<Global>("/root/Global");


        if (g.plastic)
        {
            anim.Text = "+1 Plastic";
        }
        else if (g.paper)
        {
            anim.Text = "+1 Paper";
        }
        else if (g.glass)
        {
            anim.Text = "+1 Glass";
        }

        WaitTime = 1f;
    }
}
