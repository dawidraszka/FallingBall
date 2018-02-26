using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	public float speed = 0.75f;
	
	void Update () {
		transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
	}

}
