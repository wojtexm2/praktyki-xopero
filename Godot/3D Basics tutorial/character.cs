using Godot;
using System;

public partial class character : CharacterBody3D
{
	[Export] NodePath CameraNodePath;
	Node3D Head;
	[Export] NodePath HeadNodePath;
	Camera3D Camera;
	const float MouseSensitivity = 0.3f;

	#region "Movement"

	#endregion

	public const float Speed = 8.0f;
	public const float JumpVelocity = 9f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/3d/default_gravity").AsSingle();

    public override void _Ready()
    {
        Head = GetNode<Node3D>(HeadNodePath);
		Camera = GetNode<Camera3D>(CameraNodePath);
		Input.MouseMode = Input.MouseModeEnum.Captured;
    }

    public override void _PhysicsProcess(double delta)
	{
		Vector3 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y -= gravity*2 * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
			velocity.Y = JumpVelocity;

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 inputDir = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		Vector3 direction = (Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
		float ex_speed = Speed;
		if (Input.IsActionPressed("character_sprint"))
		{
			ex_speed *= 2f;
		}
		if (direction != Vector3.Zero)
		{
			velocity.X = direction.X * ex_speed;
			velocity.Z = direction.Z * ex_speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, ex_speed);
			velocity.Z = Mathf.MoveToward(Velocity.Z, 0, ex_speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		// Handle camera rotation
		if (Input.MouseMode == Input.MouseModeEnum.Captured) {
			InputEventMouseMotion mouseMotion = @event as InputEventMouseMotion;
			if (mouseMotion != null) {
				HandleCameraRotation(mouseMotion);
			}
		}
	}
	private void HandleCameraRotation(InputEventMouseMotion mouseMotion) {
		// Rotate up / down
		Head.RotateX(Mathf.DegToRad(-mouseMotion.Relative.Y * MouseSensitivity));
		Head.RotationDegrees = new Vector3(Mathf.Clamp(Head.RotationDegrees.X, -70, 70), Head.RotationDegrees.Y, Head.RotationDegrees.Y);

		// Rotate left / right
		RotateY(Mathf.DegToRad(-mouseMotion.Relative.X * MouseSensitivity));
	}
}

