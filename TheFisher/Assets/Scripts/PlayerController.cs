using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

/*
You have to put the "player" in the Hierachy and one (or more) "stone". Set MainCamera on Orthographic.
Click somewhere in the scene... you will see the player moving to the point you clicked on the screen.
and appearing at the front or the back of the stone(s) depending on them positions on the screen.
But! when player collide with an other collier2D, I can't make it stop moving (see OnCollisionEnter fonction at the end).
*/

	public Vector2 mousePosition;
	public float speed;

	private Rigidbody2D rb2D;
//	private Animator animator;

	void Awake ()
	{
		rb2D = GetComponent <Rigidbody2D>();
//		animator = GetComponent<Animator>();
		mousePosition = new Vector2(0f, 0f);
	}

	void FixedUpdate () 
	{
		if (Input.GetMouseButton(0))
		{
			mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
		}

		if (transform.position.x == mousePosition.x && transform.position.y == mousePosition.y)
		{
			mousePosition = new Vector2(0f, 0f);
		}

		else if (transform.position.x != mousePosition.x && transform.position.y != mousePosition.y && mousePosition.x != 0f && mousePosition.y != 0f)
		{
			rb2D.position = Vector2.MoveTowards(rb2D.position, mousePosition, speed * Time.deltaTime);
//			animator.SetTrigger ("playerWalking");
		}
	}


	// IT DOESN'T FUCKING WORK!!!! AND I DON'T UNDERSTAND FUCKING WHYYYYYYYYYY!!!
	// Fou! Toto! Need help!
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Obstacle")
		{
			Debug.Log ("Collide");
			mousePosition = new Vector2(transform.position.x, transform.position.y);
		}
	}
}
