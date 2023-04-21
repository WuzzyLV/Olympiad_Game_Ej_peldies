using Godot;
using System;
using System.Diagnostics.Eventing.Reader;

public class ItemSpawner : Godot.Timer
{

    private PackedScene paperTrash;
    private PackedScene glassTrash;
    private PackedScene plasticTrash;
    public int count = 0;
    const int maxCount = 7;
    public override void _Ready()
    {
        // Load the Trash scene resource
        paperTrash = (PackedScene)ResourceLoader.Load("res://scenes/game/trashing/Trash/Glass/Glass.tscn");
        glassTrash = (PackedScene)ResourceLoader.Load("res://scenes/game/trashing/Trash/Paper/Paper.tscn");
        plasticTrash = (PackedScene)ResourceLoader.Load("res://scenes/game/trashing/Trash/Plastic/Plastic.tscn");
    }

 
    public void _on_Timer_timeout()
    {
        Node2D paperTrash = (Node2D)this.paperTrash.Instance();
        Node2D glassTrash = (Node2D)this.glassTrash.Instance();
        Node2D plasticTrash = (Node2D)this.plasticTrash.Instance();

        if (count <= maxCount)
        {
           Random rand = new Random();

            

            paperTrash.Position = new Vector2(rand.Next(-425, 425), rand.Next(-225, 225));
            glassTrash.Position = new Vector2(rand.Next(-425, 425), rand.Next(-225, 225));
            plasticTrash.Position = new Vector2(rand.Next(-425, 425), rand.Next(-225, 225));

            int randNum = rand.Next(0, 3);
            if (randNum == 1)
            {
                AddChild(paperTrash);
            }
            else if (randNum == 2)
            {
                AddChild(glassTrash);
            }
            else
            {
                AddChild(plasticTrash);
            }
            
                
            
            
            count++;
            
            WaitTime = rand.Next(2, 4);
        }
      
    }
}

  



