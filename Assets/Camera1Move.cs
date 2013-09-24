using UnityEngine;
using System.Collections;

public class Camera1Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time>0f)
		{
			transform.position += new Vector3(2f, 0f, 0f)*Time.deltaTime;
		}
	}
}
