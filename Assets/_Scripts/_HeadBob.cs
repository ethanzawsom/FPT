using UnityEngine;
using System.Collections;

public class _HeadBob : MonoBehaviour
{
	private bool headBob;
	private Vector3 currentPosition;
	private Vector3 previousPosition;
	void Update ()
	{
		if (GetComponent<Rigidbody>().velocity.magnitude > 1)
		{
			headBob = true;
		}
		else
		{
			headBob = false;
		}
	}
}