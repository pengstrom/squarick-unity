using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour {

	public GameObject tilePrefab;

	public float spread = 1f;

	private List<GameObject> tiles;

	void Start () {
		const int max = 10;

		tiles = new List<GameObject>();

		for (int i = 0; i < max; i++)
		{
			float x = Random.value;
			Color color = x < 0.5 ? Color.red : Color.blue;

			GameObject tile = Instantiate(tilePrefab);
			tile.transform.SetParent(transform);

			scalePos(tile, i);

			tile.GetComponent<ITileHandler>().SetColor(color);

			tiles.Add(tile);
		}
	}

	void Update () {
		for (int i = 0; i < tiles.Count; i++)
		{
			GameObject tile = tiles[i];
			scalePos(tile, i);
		}
	}

	void scalePos(GameObject tile, int i) {
		float margin = Mathf.Exp(-i*spread);
		var position = new Vector3(0, -margin*5, i);
		tile.transform.position = position;
		tile.transform.localScale = new Vector3(margin, margin, margin);
	}
}
