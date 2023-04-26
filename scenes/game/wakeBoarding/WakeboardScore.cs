using Godot;
using System;

public class WakeboardScore : Label
{

    [Export] public NodePath timerPath;
    Timer Timer;

    public override void _Ready()
    {
        Text = "Punkti: 0";
    }

    public override void _Process(float delta)
    {
        ObjectSpawner timer = GetNode<ObjectSpawner>(timerPath);
        Text = "Punkti: " + (int)timer.time;
        
    }


}
