using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	public int moveSpeed = 250;

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}

	public void GetInput()
	{
		var input_direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		this.Velocity = input_direction * moveSpeed;
	}
}
