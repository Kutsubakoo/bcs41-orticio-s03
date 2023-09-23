using Godot;
using System;

public class Scenes : Node2D
{
    
    public override void _Ready()
    {
        GD.Print("Hello World");
    }

// Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        Godot.Sprite child = GetNode<Sprite>("Sprite");
        float amount = 5;

        if((Input.IsKeyPressed((int)KeyList.W))){
            this.Position += new Vector2(0, -amount);
            
        }
        if((Input.IsKeyPressed((int)KeyList.S))){
            this.Position += new Vector2(0, +amount);
           
        }
        if((Input.IsKeyPressed((int)KeyList.A))){
            this.Position += new Vector2(-amount, 0);
        
        }
        if((Input.IsKeyPressed((int)KeyList.D))){
            this.Position += new Vector2(+amount, 0);
            
        }
    }
}
