using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	private Renderer meshRenderer;
	private Vector2 initialOffset;
	public float horizontalScrollSpeed = 0.1f;
	private IEnumerator coroutine;

	void Start () {
		meshRenderer = GetComponent<Renderer> ();
//		initialOffset = meshRenderer.sharedMaterial.GetTextureOffset ("_MainTex");
		initialOffset = meshRenderer.material.GetTextureOffset ("_MainTex");
		coroutine = Display ();
		StartCoroutine (coroutine);
		Debug.Log ("In Start...");

	}
	
	// Update is called once per frame
	void Update () {
		float x = Time.time * horizontalScrollSpeed;
		Vector2 offset = new Vector2 (x,0);
	//	meshRenderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
		meshRenderer.material.SetTextureOffset ("_MainTex", offset);

	}


	private IEnumerator Display() {
		Debug.Log ("In Coroutine...");
		yield return new WaitForSeconds(2f);
		Debug.Log ("In Coroutine after wait...");

	}

	void Disable() {
//		meshRenderer.sharedMaterial.SetTextureOffset ("_MainTex", initialOffset);
		meshRenderer.material.SetTextureOffset ("_MainTex", initialOffset);

	}
}
