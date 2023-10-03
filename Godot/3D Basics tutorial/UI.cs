using Godot;
using System;

public partial class UI : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	[Export] NodePath interactionLabelNodePath;
	RichTextLabel interactionLabel;
	public override void _Ready()
	{
		//GetParent().Connect("InteractableUpdated", this, Convert.ToUInt16("InteractableUpdatedCallback"));
		interactionLabel = GetNode<RichTextLabel>(interactionLabelNodePath);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void InteractableUpdatedCallback(Godot.GodotObject interactableObject) {
		var interactable = interactableObject as IInteractable;
		if (interactable == null || !interactable.CanInteract(GetParent())) {
			interactionLabel.Text = "";
		} else {
			interactionLabel.Text = interactable.InteractionText;
		}
	}
}
