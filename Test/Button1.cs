using Godot;
using System;

public class Button1 : Button
{
    TestScene t;
    Global g;


    public void question1()
    {
        t = GetNode<TestScene>("/root/TestScene");
        
        Text = "A. Blue";
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
    }



}
