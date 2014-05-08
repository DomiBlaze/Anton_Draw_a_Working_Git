using UnityEngine;
using System.Collections;

public class floor_is_top : MonoBehaviour {

	public LayerMask Player;
	//public GameObject PlayerObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.layer == 8) {
			//Debug.Log ("hehe",Player);
			other.gameObject.transform.parent.gameObject.rigidbody2D.gravityScale = -1.7f;
		}
			Destroy (gameObject);
	}
}
