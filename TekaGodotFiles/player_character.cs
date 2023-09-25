using Godot;
using System;

public partial class player_character : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		if (Input.is_action_pressed("up"))
		{
			velocity.y -= 1;
			direction = Vector2(0,-1);
		}
	}
}
