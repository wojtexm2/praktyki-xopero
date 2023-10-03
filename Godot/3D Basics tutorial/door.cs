using Godot;
using System;
using System.Dynamic;

public partial class door : StaticBody3D, IActivable, IInteractable
{
	[Export] NodePath AnimationPlayerNodePath;
	AnimationPlayer AnimationPlayer;
	[Export] public bool IsInteractable { get; set; } = true;
	private bool isOpen = false;

    public string InteractionText {get { return "Open"; } }

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
	}
	public void Deactivate()
	{
		AnimationPlayer.PlayBackwards();
		isOpen = false;
	}
	public void Activate(Node caller)
	{
		Activate();
	}

    public void Interact(Node caller)
    {
        Activate();
    }

    public bool CanInteract(Node caller)
    {
        return IsInteractable && !isOpen && caller is character;
    }

}
