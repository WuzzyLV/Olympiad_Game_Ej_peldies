using Godot;
using System;

public class Area2D : Godot.Area2D
{
	bool colliding = false;
	public void _on_Wakeboard_body_entered(Node body)
	{
		if(body.Name == "player")
			colliding = true;
	}
	public void _on_Wakeboard_body_exited(Node body)
	{
		if(body.Name == "player")
			colliding = false;
	}

	public override void _PhysicsProcess(float delta)
	{
		if (!colliding)
			return;
		if (!Input.IsActionJustPressed("interact"))
			return;
		
		GetTree().ChangeScene("res://scenes/game/WakeBoardingScene.tscn");
	}
}
