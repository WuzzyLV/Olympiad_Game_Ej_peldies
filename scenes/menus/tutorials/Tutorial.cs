using Godot;
using System;

public class Tutorial : Control
{

    public override void _Ready()
    {
        var pauseState = !GetTree().Paused;
        GetTree().Paused = pauseState;
        Visible = pauseState;
    }
    
    public void _on_Continue_pressed()
    {
        GetTree().Paused = false;
        Visible = false;
    }


}
