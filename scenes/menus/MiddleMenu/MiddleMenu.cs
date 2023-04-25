using Godot;

public class MiddleMenu : CanvasLayer
{
    public int score;
    public Godot.Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Godot.Label>("Pause/Label");
    }

    public void setScore(int score)
    {
        scoreLabel.Text = "Spēles punktu skaits: " + score;
    }

    public void show()
    {
        var pauseState = !GetTree().Paused;
        GetTree().Paused = pauseState;
        Visible = pauseState;
    }


}
