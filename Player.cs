using Godot;
using System;

public class Player : Area2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	public override void _Process(float delta)
  	{
		Position.Set(Position.x +1, Position.y);
  	}

	private void _on_Player_area_entered(object area)
	{
		if (area is Player2 enemy){
			GD.Print("Hit");
		}
	}


}


