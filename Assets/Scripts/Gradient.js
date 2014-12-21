#pragma strict

var startColor = Color.white;
var endColor = Color.black;

function Start () {
	var mesh = GetComponent(MeshFilter).mesh;
	var colors = new Color[mesh.vertices.Length];
	colors[0] = endColor;
	colors[1] = startColor;
	colors[2] = startColor;
	colors[3] = endColor;
	mesh.colors = colors;
}