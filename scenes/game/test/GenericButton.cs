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
            AddColorOverride("font_color_disabled", new Color(0, 1, 0));
            Disabled=true;
            root.RightAnswer();
        }
        else
        {
            root.WrongAnswer();
            AddColorOverride("font_color_disabled", new Color(1, 0, 0));
            Disabled=true;
        }
    }
}
