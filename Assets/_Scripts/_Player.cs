using UnityEngine;
using System.Collections;

public class _Player : MonoBehaviour {
	public float walkSpeed = 50;
	public float maxSpeed = 100;
	public float jumpHeight;
	public float lookSensitivity;
	public AudioClip footstepSound1;
	public AudioClip footstepSound2;
	public AudioClip footstepSound3;
	public AudioClip footstepSound4;
	public AudioClip jumpSound;
	public AudioClip landSound;
	private Vector3 input;
	private bool jumping = false;
	private void jump()
	{
		jumping = false;
	}

	void Start ()
	{

	}
	void Update ()
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		if (jumping)
		{
			if (GetComponent<Rigidbody>().velocity.magnitude < maxSpeed)
			{
				GetComponent<Rigidbody>().AddForce (input * walkSpeed);
			}
				if (Input.GetKey(KeyCode.LeftShift))
			{
				walkSpeed =+ 100;
			}
			else
			{
				walkSpeed =+ 50;
			}
		}
		if (Input.GetButtonDown ("Jump"))
		{
			GetComponent<Rigidbody>().AddForce(transform.up*jumpHeight);
			jumping = true;
			Invoke ("jump", 1.5f);
			GetComponent<AudioSource>().PlayOneShot(jumpSound);
		}
	}
}