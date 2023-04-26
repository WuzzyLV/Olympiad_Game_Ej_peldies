using Godot;
using System;

public class Playtime : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private static ulong _startTime = 0;
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _startTime = OS.GetUnixTime();
    }


    public static ulong GetPlaytime()
    {
        return OS.GetUnixTime() - _startTime;
    }
    public static string GetPlaytimeString()
    {
        ulong playtime = GetPlaytime();
        GD.Print(playtime);
        ulong hours = playtime / 3600;
        ulong minutes = (playtime % 3600) / 60;
        ulong seconds = playtime % 60;
        return hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
