using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		Destroy(gameObject);
		Destroy (GameObject.Find ("rod"));
		light.enabled = true;
	}
}
