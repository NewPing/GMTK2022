using Godot;
using System;
using System.Collections.Generic;

public class Game : Node2D
{
	PackedScene heroKnightRes = (PackedScene)ResourceLoader.Load("res://HeroKnight.tscn");
	List<KinematicBody2D> heroKnightList = new List<KinematicBody2D>();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public override void _PhysicsProcess(float delta)
	{
		var heroKnightToRemove = new List<KinematicBody2D>();
		foreach(var hero in heroKnightList){
			if (hero.Position.x > 300)
			{
				heroKnightToRemove.Add(hero);
			}
		}
		foreach(var hero in heroKnightToRemove){
			heroKnightList.Remove(hero);
			RemoveChild(hero);
		}
	}
	
	private void _on_HeroKnightSpawn2_pressed()
	{
		KinematicBody2D heroKnight = (KinematicBody2D)heroKnightRes.Instance();
		heroKnight.Position = new Vector2( 218, -68 );
		heroKnightList.Add(heroKnight);
		AddChild(heroKnight);
	}


	private void _on_HeroKnightSpawn_pressed()
	{
		KinematicBody2D heroKnight = (KinematicBody2D)heroKnightRes.Instance();
		heroKnight.Position = new Vector2( 218, -68 );
		heroKnightList.Add(heroKnight);
		AddChild(heroKnight);
	}
}


