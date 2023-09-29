using Godot;
using System;

public partial class DoHurt : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Pressed()
	{
		Globals G = (Globals)GetNode("/root/gm");
		G.health -= 5;
	}
	public override void _Process(double delta)
	{
		Globals G = (Globals)GetNode("/root/gm");
		Label l = (Label)GetNode("Label");
		l.Text = G.health.ToString();
	}
}
