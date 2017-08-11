using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTile : MonoBehaviour, ITileHandler {

	private SpriteRenderer renderer;

	void Awake () {
		renderer = GetComponent<SpriteRenderer>();
	}

	public void SetColor(Color color) {
		renderer.color = color;
	}
}
