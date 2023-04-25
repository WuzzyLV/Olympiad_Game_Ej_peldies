using Godot;
using System;
using Godot.Collections;

public class PlayerProgress : Node
{

    public enum Tasks
    {
        BoatGameBeberlini,
        FishingBeberlini,
        TrashPludmale,
        TestBeberlini,
        TestPludmale,
    }
    //Map for Tasks and bools
    private static Dictionary<Tasks, bool> _tasksCompleted = new Dictionary<Tasks, bool>();

    public static String LastScene = "";
    
    public override void _Ready()
    {
        
    }

    
    public static bool IsTaskCompleted(Tasks task)
    {
        return _tasksCompleted[task];
    }

    public static void TaskFinished(Tasks task)
    {
        if (_tasksCompleted.ContainsKey(task))
            return;
        
        _tasksCompleted.Add(task, true);
    }
}
