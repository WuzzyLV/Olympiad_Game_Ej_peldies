using Godot;
using System;

public class TrashingButton : Button
{
	public void _on_Button2_pressed()
	{
		GetTree().ChangeScene("res://scenes/game/TrashScene.tscn");
	}
}
