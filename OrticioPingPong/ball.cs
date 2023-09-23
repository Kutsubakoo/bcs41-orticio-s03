using Godot;
using System;


public class ball : KinematicBody2D
{
    public float speed = 5;
    public Vector2 velocity = new Vector2(100, 100);
    public Vector2 InitialPosition;

    public override void _Ready()
    {
        InitialPosition = Position;
    }

 // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(float delta)
    {
        var collision = MoveAndCollide(velocity * delta * speed);
        if (collision != null)
        {
            velocity = velocity.Bounce(collision.Normal);
        }
        
    }

    public void _on_leftWall_body_entered(Node body)
    {
        Position = InitialPosition;
    }
    public void reset()
    {
        Position = InitialPosition;

    }

    

}
