using Godot;
using System;

public class Button4 : Button
{
    TestScene t;
    Global g;
    public void question1()
    {
        t = GetNode<TestScene>("/root/TestScene");
        
            Text = "D. Red";
            if (Pressed)
            {
                t.question++;
            }
        
    }

    public void question2()
    {
        t = GetNode<TestScene>("/root/TestScene");
            Text = "D. Red";
            if (Pressed)
            {
                GD.Print("Wrong");
            }
    }

    public override void _Process(float delta)
    {
        t = GetNode<TestScene>("/root/TestScene");

        if (t.question == 1)
        {
            question1();
        }
        if (t.question == 2)
        {
            question2();
        }



    }
}
