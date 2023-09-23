using Godot;
using System;

public class paddle2 : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
        float amount = 5;

        if((Input.IsKeyPressed((int)KeyList.I))){
            this.Position += new Vector2(0, -amount);
            
        }
        if((Input.IsKeyPressed((int)KeyList.K))){
            this.Position += new Vector2(0, +amount);
           
        }
    }
}
