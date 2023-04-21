using Godot;
using System;

public class PlayerController : Godot.PathFollow2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export] public String Key = "left_click";
    [Export]
    public float Speed = 10;
    [Export]
    public float VelocityCap = 500;

    float _curveLen;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _curveLen= GetParent<Path2D>().Curve.GetBakedLength();
        GD.Print(_curveLen);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if (Input.IsActionPressed(Key))
        {
            float lastVel=_velocity;
            AddVelocity(Speed);
        }
        else
        {
            AddVelocity(Speed * -1);
        }
        GD.Print(_velocity+":"+Offset);
        Offset= Offset + _velocity * delta;
    }

    float _velocity = 0;
    void AddVelocity(float velocity)
    {
        this._velocity += velocity;
		
        //If sitting on the bottom dont let it accelarate
        if (Offset <= 0 && velocity < 0)
        {
            this._velocity = 0;
            return;
        }
        //If you hit the top set vel to 0 cause u cant accelarate in a wall
        if (Offset >= _curveLen && velocity > 0) 
        {
            this._velocity = 0;
        }
        //If vel cap reached reset to vel cap 
        if (this._velocity > VelocityCap)
        {
            this._velocity = VelocityCap;
            return;
        }
		
        if (this._velocity < VelocityCap*-1)
        {
            this._velocity= VelocityCap*-1;
            return;
        }
    }

}
