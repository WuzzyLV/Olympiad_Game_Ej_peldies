using Godot;
using System;

public class Question : Label
{
    TestScene t;

    public override void _Process(float delta)
    {
        t = GetNode<TestScene>("/root/TestScene");
        if (t.question == 1)
        {
           
            Text = "What color is the trash bin, where you put plastic?";
        }

        if (t.question == 2)
        {
            Text = "What is the right color for glass trash bin?";
        
        }
    }
}
