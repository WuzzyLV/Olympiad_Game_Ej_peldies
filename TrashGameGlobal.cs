using Godot;
using System;

public class TrashGameGlobal : Node
{
    public int score = 0, testScore = 0;
    public bool picked = false;
    public bool plastic;
    public bool glass;
    public bool paper;
    public bool dropped;
    public float timePlayed =0f;



    public override void _PhysicsProcess(float delta)
    {
        timePlayed += delta;
    }

}
