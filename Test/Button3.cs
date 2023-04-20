using Godot;
using System;

public class Button3 : Button
{

    TestScene t;
    Global g;
    public void question1()
    {
        t = GetNode<TestScene>("/root/TestScene");
        g = GetNode<Global>("/root/Global");
        
        Text = "C. Orange";
        if (Pressed)
        {
            g.testScore++;
            t.question++;
            GD.Print("Right");
        }
        
    }


    public override void _Process(float delta)
    {
        t = GetNode<TestScene>("/root/TestScene");
        if (t.question == 1)
        {
            question1();
        }
    }



}
