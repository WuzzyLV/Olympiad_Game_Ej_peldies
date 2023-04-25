using Godot;
using System;

public class LocationButton : Button
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] public String ToGoScene= "res://scenes/MainScene.tscn";

	private RichTextLabel _desc;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_desc=GetChild<RichTextLabel>(0);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	public void Pressed()
	{
		Godot.ResourceLoader.Load(ToGoScene);
		GetTree().ChangeScene(ToGoScene);
	}

	public void MouseEntered()
	{
		GD.Print("Mouse Entered");
		_desc.Visible = true;
	}
	public void MouseExited()
	{
		GD.Print("Mouse Exited");
		_desc.Visible = false;
	}
	
}
