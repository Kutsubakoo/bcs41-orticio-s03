using Godot;
using System;

public class leftWall : Area2D
{
    public Label Player1ScoreLabel;
    public Label Player2ScoreLabel;

    public int Player1Score { get; private set; }
    public int Player2Score { get; private set; }
    public override void _Ready()
    {
        Player1ScoreLabel.Text = "0";
        Player2ScoreLabel.Text = "0";
    }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
    }

    public void OnLeftSideBodyEntered(Node body)
    {
        Player2Score++;
        UpdateScoreLabels();
    }

    public void OnRightSideBodyEntered(Node body)
    {
        Player1Score++;
        UpdateScoreLabels();
    }

    private void UpdateScoreLabels()
    {
        Player1ScoreLabel.Text = Player1Score.ToString();
        Player2ScoreLabel.Text = Player2Score.ToString();
    }

}
