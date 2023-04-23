using Godot;

public class GenericButton : Button
{
    [Export]
    public bool CorrectAnswer;

    private TestRootNode root;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        root = GetParent<TestRootNode>();   
    }

    public override void _Pressed()
    {
        if (root.IsGameOver())
        {
            return;
        }
        if (CorrectAnswer)
        {
            root.RightAnswer();
        }
        else
        {
            root.WrongAnswer();
            Hide();
        }
    }
}
