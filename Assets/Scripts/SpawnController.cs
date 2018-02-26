using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public Transform[] boundaries;
	public GameObject platformPrefab;
	public GameObject spikePrefab;

	public float minScaleX = 0.5f;
	public float maxScaleX = 3f;
	public float probabilityOfSpike = 0.33f;

	public int spikesInRowLimit = 2;
	
	public float minDistance = 1f;
	public float maxDistance = 5f;

	private float positionY;
	private float nextSpawnPosition;

	private int spikesInRow;

	void Start () {
		nextSpawnPosition = Mathf.Abs(transform.position.y);
	}

	void FixedUpdate () {
		positionY = Mathf.Abs(transform.position.y);
		if (positionY >= nextSpawnPosition)
		{
			nextSpawnPosition += Random.Range(minDistance, maxDistance);
			Spawn();
		}
	}
	
	void Spawn()
	{
		GameObject objectToSpawn;

		float scaleX = Random.Range(minScaleX, maxScaleX);
		float scaleY;

		float positionX = Random.Range(boundaries[0].position.x, boundaries[1].position.x);

		if (spikesInRow < spikesInRowLimit && Random.value < probabilityOfSpike)
		{
			++spikesInRow;
			objectToSpawn = Instantiate(spikePrefab);
			scaleY = scaleX;
		}
		else
		{
			objectToSpawn = Instantiate(platformPrefab);
			scaleY = objectToSpawn.transform.localScale.y;
			spikesInRow = 0;
		}
  
		objectToSpawn.transform.position = new Vector2(positionX, transform.position.y);
  
		objectToSpawn.transform.localScale = new Vector2(scaleX, scaleY);
	}
}
