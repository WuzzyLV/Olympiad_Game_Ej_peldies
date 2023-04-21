using Godot;
using System;
using System.Management.Instrumentation;

public class Score : Node
{
    
    private static int _score= 0; 
    public static int GetScore()
    {
        return _score;
    }
    
    public static void SetScore(int score)
    {
        _score = score;
    }

    public static void AddScore(int score)
    {
        _score += score;
    }
    public static void TakeScore(int score)
    {
        _score -= score;
    }

}
