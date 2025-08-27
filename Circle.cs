using Godot;
using System;

public partial class Circle : CharacterBody2D
{
    public override void _PhysicsProcess(double delta)
    {
        int speed = 100;
        float floatDelta = (float)delta;
        if (Input.IsActionPressed("left"))
        {
            Position -= new Vector2(100 * floatDelta, 0);
        }
        else if (Input.IsActionPressed("right"))
        {
            Position += new Vector2(100 * floatDelta, 0);
        }
        else
        {
            
        }
    }
}
