using Godot;
using System;

public partial class pressure_plate : Node3D
{
	[Signal] public delegate void OnActivated();
	[Signal] public delegate void OnDeactivated();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public void body_entered(object Body)
	{
		EmitSignal(nameof(OnActivated));
	}
	public void body_exited(object Body)
	{
		EmitSignal(nameof(OnDeactivated));
	}
}
