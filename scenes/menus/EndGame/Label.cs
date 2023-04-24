using Godot;
using System;

public class Label : Godot.Label
{

    public override void _Ready()
    {
        Text = "Paldies par spēli, tavu punktu sakits: " + Score.GetScore();
    }



}
