using Godot;
using System;
using Godot.Collections;

public class PlayerProgress : Node
{

    public enum Tasks
    {
        None,
        BoatGameBeberlini,
        FishingBeberlini,
        FishingEzers,
        TrashPludmale,
        TestBeberlini,
        TestPludmale,
        TestEzers
    }
    //Map for Tasks and bools
    private static Dictionary<Tasks, bool> _tasksCompleted = new Dictionary<Tasks, bool>();

    public static String LastScene = "res://scenes/menus/MainMenu.tscn";
    
    public override void _Ready()
    {
        
    }

    
    public static bool IsTaskCompleted(Tasks task)
    {
        return _tasksCompleted.ContainsKey(task);
    }

    public static void TaskFinished(Tasks task)
    {
        if (task==Tasks.None)
            return;
        if (_tasksCompleted.ContainsKey(task))
            return;
        
        _tasksCompleted.Add(task, true);
    }
}
