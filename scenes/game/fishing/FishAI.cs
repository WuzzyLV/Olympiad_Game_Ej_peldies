using Godot;
using System;

public class FishAI : PathFollow2D
{
    private Random _random = new Random();
    private Path2D _path;
    private float _targetOffset;
    private float _maxSpeed = 1f; // Maximum speed of the object
    private float _minSpeed = 0f; // Minimum speed of the object
    private string _easingFunc = "quad_out"; // Easing function to use for interpolation

    public override void _Ready()
    {
        _path = GetParent<Path2D>();
        _targetOffset = GetRandomOffset();
    }

    public override void _Process(float delta)
    {
        // Move towards the target offset
        float direction = _targetOffset - Offset;
        float distance = Math.Abs(direction);
        float speed = InterpolateSpeed(distance, _minSpeed, _maxSpeed, _easingFunc);
        Offset += direction * delta * speed;

        // Check if we have reached the target offset
        if (distance < 10f)
        {
            _targetOffset = GetRandomOffset();
        }
    }

    private float GetRandomOffset()
    {
        // Generate a random offset along the path
        return _random.Next(0, (int)_path.Curve.GetBakedLength());
    }

    private float InterpolateSpeed(float distance, float minSpeed, float maxSpeed, string easingFunc)
    {
        // Interpolate the object's speed based on its distance from the target offset
        float t = 1f - distance / _path.Curve.GetBakedLength();
        t = Mathf.Clamp(t, 0f, 1f);
        float interp = Ease(t, easingFunc);
        return Mathf.Lerp(minSpeed, maxSpeed, interp);
    }

    private float Ease(float t, string easingFunc)
    {
        // Apply the specified easing function to t
        switch (easingFunc)
        {
            case "linear":
                return t;
            case "quad_in":
                return t * t;
            case "quad_out":
                return -t * (t - 2f);
            case "quad_in_out":
                return t < 0.5f ? 2f * t * t : -1f + (4f - 2f * t) * t;
            // Add more easing functions here as needed
            default:
                return t;
        }
    }
}
