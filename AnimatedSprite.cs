using Godot;
using System;

public class AnimatedSprite : Godot.AnimatedSprite
{

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}
	
	private void _on_Button_pressed()
	{
		 Play("attack");
	}
	
	private void _on_Sohn_animation_finished()
	{
		Play("default");
	}
}





