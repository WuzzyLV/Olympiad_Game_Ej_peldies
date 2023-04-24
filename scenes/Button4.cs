using Godot;
using System;

public class Button4 : Button
{

private void _on_Button4_pressed()
{
	GetTree().ChangeScene("res://scenes/game/Beberlini.tscn");
}
}
