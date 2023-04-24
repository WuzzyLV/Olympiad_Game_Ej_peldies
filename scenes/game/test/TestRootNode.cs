using Godot;
using System;

public class TestRootNode : Node2D
{
    [Export] public int Health = 2;
    [Export] public String Question = "What is the capital of Canada?";
    /*
     * First index is the correct answer
     */
    [Export] public String[] Answers = {"Ottawa","Toronto", "Montreal", "Vancouver"};

    private int _correctAnswerIndex = 0;
    private bool _gameOver = false;
    private GenericButton[] _buttons= new GenericButton[4];
    
    private Label _healthLabel;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _healthLabel = GetNode<Label>("Health");
        UpdateHealthLabel();
        //Set question to label
        GetNode<Label>("Question").Text = Question;

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
        GD.Print("Game Won");
        //send to somewhere
    }

    public void WrongAnswer()
    {
        Health--;
        UpdateHealthLabel();
        if (Health <= 0)
        {
            _gameOver = true;
            GD.Print("Game Over");
        }
    }
    
    private void UpdateHealthLabel()
    {
        _healthLabel.Text = "Health: " + Health;
    }
    
    /*
     * True if game is over
     */
    public bool IsGameOver()
    {
        return _gameOver;
    }
}
