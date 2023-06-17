using Godot;
using System;

public partial class node_3d : Node3D
{
	// Called when the node enters the scene tree for the first time.
	Node3D originalModel = new();

	public override void _Ready()
	{
		Node3D duplicateModel = originalModel.Duplicate() as Node3D;
		AddChild(originalModel);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
