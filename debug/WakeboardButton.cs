using Godot;
using System;

public class WakeboardButton : Button
{
  public void _on_Button3_pressed()
    {
        GetTree().ChangeScene("res://scenes/game/WakeBoardingScene.tscn");
  }
}
