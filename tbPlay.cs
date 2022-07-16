using Godot;
using System;

public class tbPlay : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public void _on_TextureButton_pressed()
	{
		//GetTree().ChangeScene("res://Game.tscn");
	}

}
