using Godot;
using System;

public class HeroKnight : KinematicBody2D
{
 	private const int MoveSpeed = 100;
	private int _movementDirection;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_movementDirection = 1; //1 right; -1 left
	}
	
	public override void _PhysicsProcess(float delta){
		float input = _movementDirection;
		Vector2 position = Position;
		position = position.Normalized();
		position += new Vector2(input * MoveSpeed, 0);
		//Position = position;
		
		var collisionObj = MoveAndCollide(position * delta);
		if (collisionObj != null){
			GD.Print(((Node)collisionObj.Collider));
			((KinematicBody2D)collisionObj.Collider).MoveAndCollide(position * delta);
		}
	}
}






