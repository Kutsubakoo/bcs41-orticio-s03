using Godot;

public class Scoreboard : Node2D
{
    public Label Player1ScoreLabel;
    public Label Player2ScoreLabel;
    public Node Ball;
    public Vector2 InitialPosition;


    public int Player1Score { get; private set; }
    public int Player2Score { get; private set; }

    public override void _Ready()
    {
        Player1ScoreLabel.Text = "0";
        Player2ScoreLabel.Text = "0";
    }

    public void _on_leftWall_body_entered(Node body)
    {
        Player2Score++;
        UpdateScoreLabels();
    }

    public void _on_rightWall_body_entered(Node body)
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