using Godot;
using System;

public partial class door : StaticBody3D, IActivable
{
	[Export] NodePath AnimationPlayerNodePath;
	AnimationPlayer AnimationPlayer;
	private bool isOpen = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AnimationPlayer = GetNode<AnimationPlayer>(AnimationPlayerNodePath);
		AnimationPlayer.AssignedAnimation = AnimationPlayer.GetAnimationList()[0];
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void Activate()
	{
		if (isOpen) return;
		isOpen = true;
		AnimationPlayer.Play();
		GD.Print("DOOR ACIVATED!");
	}
	public void Decativate()
	{
		AnimationPlayer.PlayBackwards();
		isOpen = false;
	}
	public void Activate(Node caller)
	{
		Activate();
	}
}
