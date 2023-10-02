using Godot;
using System;
using System.Threading.Tasks.Dataflow;

public partial class Label : Godot.Label
{
	public void ValueChanged(float value)
	{
		Text = value.ToString();
	}
}
