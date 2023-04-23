using Godot;
using System;

public class ObjectSpawner : Godot.Timer
{
    private PackedScene object1;

    public override void _Ready()
    {
        // Load the Trash scene resource
        object1 = (PackedScene)ResourceLoader.Load("res://scenes/game/wakeBoarding/Object.tscn");
     
    }

    public void _on_Timer_timeout()
    {
        Node2D object1 = (Node2D)this.object1.Instance();
            
            float height = GetViewport().Size.y;
            Random rand = new Random();
            GD.Print("test");
            object1.Position = new Vector2(rand.Next(-100, 100), -300);
            GD.Print(height);
            int randNum = rand.Next(0, 3);

            AddChild(object1);

            WaitTime = rand.Next(1, 3);
            
    }
    float time;
    public override void _PhysicsProcess(float delta)
    {
        time += delta;
        GD.Print((int)time);

    }
}
