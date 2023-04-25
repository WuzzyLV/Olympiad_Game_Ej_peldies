using Godot;
using System;

public class Pause : Control
{
    
    public void gameEnd()
    {
        var pauseState = !GetTree().Paused;
        GetTree().Paused = pauseState;
        Visible = pauseState;
    }
        
    
}
