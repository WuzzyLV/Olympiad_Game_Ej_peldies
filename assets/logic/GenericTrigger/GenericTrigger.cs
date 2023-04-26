using Godot;
using System;

public class GenericTrigger : Area2D
{
    
    [Export] public String ToGoScene = "res://scenes/menus/MainMenu.tscn";
    [Export] public String ReturnScene = "res://scenes/worlds/liepajas_ezers/LiepajasEzers.tscn";
    [Export] public PlayerProgress.Tasks Task;
    [Export] public String Hotkey = "interact";

    
    private bool isColliding = false;
    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        if (!isColliding)
            return;
        if (PlayerProgress.IsTaskCompleted(Task))
            return;
        
        if (Input.IsActionJustPressed(Hotkey))
        {
            PlayerProgress.LastTask=Task;
            PlayerProgress.LastScene= ReturnScene;
            GetTree().ChangeScene(ToGoScene);   
        }
    }


    //Signals
    public void BodyEntered(Node body)
    {
        if(body.Name == "player")
            isColliding = true;
    }
    //redundant for now
    public void BodyExited(Node body)
    {
        if(body.Name == "player")
            isColliding = false;
    }

}
