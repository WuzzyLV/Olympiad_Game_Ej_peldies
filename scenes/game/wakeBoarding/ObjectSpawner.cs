using Godot;
using System;

public class ObjectSpawner : Godot.Timer
{
    private PackedScene object1;
    private PackedScene object2;

    public override void _Ready()
    {
        // Load the Trash scene resource
        object1 = (PackedScene)ResourceLoader.Load("res://scenes/game/wakeBoarding/Log.tscn");
        object2 = (PackedScene)ResourceLoader.Load("res://scenes/game/wakeBoarding/Rock.tscn");
    }

    public void _on_Timer_timeout()
    {
        Node2D object1 = (Node2D)this.object1.Instance();
        Node2D object2 = (Node2D)this.object2.Instance();

            float height = GetViewport().Size.y;
            Random rand = new Random();
            object1.Position = new Vector2(rand.Next(424, 600), 0);
            object2.Position = new Vector2(rand.Next(424, 600), 0);

            int randItem = rand.Next(0, 2);
            if(randItem == 0)
                AddChild(object1);
            else
                AddChild(object2);

            //need a way to get the actual player position cant cause inside scene
            /*Node2D targettedObj=(Node2D)this.object1.Instance();
            GD.Print(GetNode<Node2D>("/root/Node2D/Player/").Position.x);
            targettedObj.Position= new Vector2(GetNode<Node2D>("/root/Node2D/Player/Boat").Position.x
                , 0);
            AddChild(targettedObj);*/
            
            WaitTime = rand.Next(1, 2);
            
    }
    public float time;
    public override void _PhysicsProcess(float delta)
    {
        time += delta;

    }
}
