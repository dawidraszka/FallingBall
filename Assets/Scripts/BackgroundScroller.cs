using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

	public float scrollingSpeed = 0.75f;

	private float lenght;
	private Vector3 startingPosition;

	void Start ()
	{
		lenght = transform.localScale.y / 2;

		startingPosition = transform.localPosition;
	}
	
	void Update ()
	{  
		float newPosition = Mathf.Repeat(Time.time * scrollingSpeed, lenght);

		transform.localPosition = startingPosition + Vector3.up * newPosition;
	}
}
