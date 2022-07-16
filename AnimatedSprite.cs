using Godot;
using System;

public class AnimatedSprite : Godot.AnimatedSprite
{
	private AnimatedSprite _animatedSprite;
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite>("Sohn");
		GD.Print("test");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
	
	private void _on_Button_pressed()
	{
		 Play("attack");
	}
	
	private void _on_Sohn_animation_finished()
	{
		Play("default");
	}
}





