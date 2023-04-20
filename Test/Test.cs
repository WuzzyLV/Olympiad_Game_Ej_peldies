using Godot;
using System;

public class Test : Control
{

    public void _on_Start_pressed()
    {
        GetTree().ChangeScene("res://Test/TestScene.tscn");
    }
    public void _on_Back_pressed() 
    {
        GetTree().ChangeScene("res://Scenes/MainMenu.tscn") ;
    
    
    }


}
