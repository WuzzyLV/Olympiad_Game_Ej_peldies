using Godot;
using System;

public class Button5 : Button
{

private void _on_Button5_pressed()
{
	GetTree().ChangeScene("res://scenes/game/Pludmale.tscn");
}
}
