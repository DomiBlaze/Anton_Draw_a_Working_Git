using UnityEngine;
using System.Collections;

public class earth_panel : MonoBehaviour {
	float activateTime;
	public GameObject TopCheck;

	//TopCheck.GetComponent<scriptName>().function();
	// Use this for initialization
	void Start () {
		TopCheck = GameObject.Find("topCheck");
	}
	
	// Update is called once per frame
	void Update () {
		if (activateTime < Time.time) {
				collider2D.enabled = true;
				}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == TopCheck) {
						collider2D.enabled = false;
			activateTime = Time.time + 0.5f;
				}
	
						
	}

}
