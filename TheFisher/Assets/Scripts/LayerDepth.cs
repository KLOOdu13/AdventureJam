using UnityEngine;
using System.Collections;

public class LayerDepth : MonoBehaviour 
{

	// This is the layer depth manager.

	public int multiplicateur;
	public SpriteRenderer spriteRenderer;

	void Start ()
	{
		spriteRenderer = GetComponent <SpriteRenderer>();
	}

	void Update ()
	{
		spriteRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y * multiplicateur);
	}
}
