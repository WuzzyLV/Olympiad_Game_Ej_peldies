using Godot;
using System;

public class WorldCompletion : Node
{

    

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    //TODO ass
    public bool IsBeberliniCompleted()
    {
        return 
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.FishingBeberlini) &&
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.BoatGameBeberlini) //&&
            //PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.TestBeberlini)
            ;
    }
}
