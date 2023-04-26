using Godot;
using System;

public class TestRootNode : Node2D
{
    [Export] public PlayerProgress.Tasks Task= PlayerProgress.Tasks.None;
    [Export] public String ReturnScene = "res://scenes/menus/MapScene.tscn";
    [Export] public int Health = 2;
    [Export] public String Question = "What is the capital of Canada?";
    /*
     * First index is the correct answer
     */
    [Export] public String[] Answers = {"Ottawa","Toronto", "Montreal", "Vancouver"};

    private int _correctAnswerIndex = 0;
    private bool _gameOver = false;
    private GenericButton[] _buttons= new GenericButton[4];
    
    private Godot.Label _healthLabel;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _healthLabel = GetNode<Godot.Label>("Health");
        UpdateHealthLabel();
        //Set question to label
        GetNode<Godot.Label>("Question").Text = Question;

        //randomize answer order
        Random rand = new Random();
        String temp = Answers[0];
        for (int i = 0; i < _buttons.Length; i++)
        {   //swap
            temp = Answers[i];
            int randNum = rand.Next(0, 3);
            Answers[i] = Answers[randNum];
            Answers[randNum] = temp;

            //update correct answer index
            if (i == _correctAnswerIndex)
            {
                _correctAnswerIndex=randNum;
            }
            else if (randNum == _correctAnswerIndex)
            {
                _correctAnswerIndex = i;
            }
        }
        //set button text and correct answer
        for (int i = 0; i < _buttons.Length; i++)
        {
            _buttons[i]=GetNode<GenericButton>("Button"+(i+1));
            _buttons[i].Text = Answers[i];
            
            if (i==_correctAnswerIndex)
            {
                _buttons[i].CorrectAnswer = true;
            }
        }
        
    }

    public void RightAnswer()
    {
        _GameEndProcedure(ReturnScene);
    }

    public void WrongAnswer()
    {
        Health--;
        UpdateHealthLabel();
        if (Health <= 0)
        {
            _gameOver = true;
            _GameEndProcedure(ReturnScene);
        }
    }
    
    private void _GameEndProcedure(String scene)
    {
        PlayerProgress.TaskFinished(Task);
        Score.AddScore(100*Health);
        GetTree().ChangeScene(scene);
    }
    
    private void UpdateHealthLabel()
    {
        _healthLabel.Text = "Meiģinājumi: " + Health;
        _healthLabel.SizeFlagsHorizontal = (int) Control.SizeFlags.ExpandFill;
    }
    
    /*
     * True if game is over
     */
    public bool IsGameOver()
    {
        return _gameOver;
    }
}
