extends Node3D

signal OnActivated
signal OnDeactivated
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass

func body_enter(node):
	emit_signal("OnActivated");

func body_exit(node):
	emit_signal("OnDeactivated");
