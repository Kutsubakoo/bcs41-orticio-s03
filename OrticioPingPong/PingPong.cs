using Godot;

public class PingPong : Node2D
{
    public Label Player1ScoreLabel;
    public Label Player2ScoreLabel;
    private ball Ball;
    public Vector2 InitialPosition;


    private int Player1Score = 0;
    private int Player2Score = 0;

    public override void _Ready()
    {
        Player1ScoreLabel = GetNode<Label>("Player1Score");
        Player2ScoreLabel = GetNode<Label>("Player2Score");

        Ball = GetNode<ball>("ball");

        if (Player1ScoreLabel != null)
            Player1ScoreLabel.Text = "0";

        if (Player2ScoreLabel != null)
            Player2ScoreLabel.Text = "0";
    }

    public void _on_leftWall_body_entered(Node2D body)
    {
        Player2Score += 1;
        UpdateScoreLabels();
        Ball.reset();
    }

    public void _on_rightWall_body_entered(Node2D body)
    {
        Player1Score += 1;
        UpdateScoreLabels();
        Ball.reset();
    }

    private void UpdateScoreLabels()
    {
        if (Player1ScoreLabel != null)
            Player1ScoreLabel.Text = Player1Score.ToString();

        if (Player2ScoreLabel != null)
            Player2ScoreLabel.Text = Player2Score.ToString();
    }

}