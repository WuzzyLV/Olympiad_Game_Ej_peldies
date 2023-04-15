using Godot;
using System;

public class ItemSpawner : Godot.Timer
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
          
            Node2D items = (Node2D)trash.Instance();

            items.Position = new Vector2(rand.Next(-425, 425), rand.Next(-225, 225));

            AddChild(items);
            count++;

            WaitTime = rand.Next(1, 3);
        }
      
    }
}

  



