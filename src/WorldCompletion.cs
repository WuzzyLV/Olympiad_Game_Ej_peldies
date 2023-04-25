using Godot;
using System;

public class WorldCompletion : Node
{

    public enum Worlds
    {
        Beberlini,
        Pludmale,
        Ezers
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }


    public static bool IsWorldComplete(Worlds world)
    {
        switch (world)
        {
            case Worlds.Beberlini:
                return IsBeberliniCompleted();
            case Worlds.Pludmale:
                return IsPludmaleCompleted();
            case Worlds.Ezers:
                return false;
            default:
                return false;
        }
    }

    //TODO ass
    public static bool IsBeberliniCompleted()
    {
        return 
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.FishingBeberlini) &&
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.BoatGameBeberlini) //&&
            //PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.TestBeberlini)
            ;
    }

    public static bool IsPludmaleCompleted()
    {
        return
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.TestPludmale) &&
            PlayerProgress.IsTaskCompleted(PlayerProgress.Tasks.TrashPludmale)
            ;
    }

    public static bool IsEzersCompleted()
    {
        return false;
    }
}
