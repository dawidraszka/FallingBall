using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBorderController : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!other.gameObject.CompareTag("Wall"))
		{
			Destroy(other.gameObject);
		}
	}
}
