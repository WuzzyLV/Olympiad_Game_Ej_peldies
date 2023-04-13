using Godot;
using System;

public class Timer : Godot.Timer
{

    private PackedScene trash;
    public int count = 0;
    const int maxCount = 7;
    public override void _Ready()
    {
        // Load the Trash scene resource
        trash = (PackedScene)ResourceLoader.Load("res://Trash/Trash.tscn");
    }

    public void _on_Timer_timeout()
    {
        if(count!=maxCount)
        {
            Random rand = new Random();
            int x = rand.Next(-200, 200);
            int y = rand.Next(-200, 200);

            Node2D items = (Node2D)trash.Instance();

            items.Position = new Vector2(x, y);

            AddChild(items);
            count++;
        }
      
    }
}

  



