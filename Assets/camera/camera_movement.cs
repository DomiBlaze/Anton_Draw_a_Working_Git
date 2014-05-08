using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {
	public float Speed = 10.0f ;
	public GameObject Earth;
	public GameObject Floor;
	public GameObject Player;
	public GameObject Bonus1;

	public float timerSet = 0.1f;
	float position = 0f;
	float timer = 0f;
	public float bonus1BlockTimerSet = 0f; //time in seconds untill next bonus1 is allowed to spawn
	float bonus1BlockTimer = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Player != null) {		
						transform.position = new Vector3 (Player.transform.position.x, 
		                                  0f, Player.transform.position.z - 10.0f);
				}
				if (timer < 0) {
						Instantiate (Floor, new Vector3 (position + 10.0f, -5f, 0f), gameObject.transform.rotation);
						timer = timerSet;
						//if (bonus1BlockTimer
					
						position += 2.0f;
						if (Random.value > 0.85f) {
								Instantiate (Floor, new Vector3 (position + 10.0f, -3.8f, -0.1f), gameObject.transform.rotation);
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, -1.5f, 0f), gameObject.transform.rotation);
								if (Random.value > 0.90f && bonus1BlockTimer > bonus1BlockTimerSet) {
										Instantiate (Bonus1, new Vector3 (position + 10.0f, -0.8f, 0f), gameObject.transform.rotation);
										bonus1BlockTimer = 0f;
								}
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, 0f, 0f), gameObject.transform.rotation);
								if (Random.value > 0.90f && bonus1BlockTimer > bonus1BlockTimerSet) {
										Instantiate (Bonus1, new Vector3 (position + 10.0f, 0.7f, 0f), gameObject.transform.rotation);
										bonus1BlockTimer = 0f;
								}
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, 1.5f, 0f), gameObject.transform.rotation);
										if (Random.value > 0.90f && bonus1BlockTimer > bonus1BlockTimerSet) {
										Instantiate (Bonus1, new Vector3 (position + 10.0f, 2.2f, 0f), gameObject.transform.rotation);
										bonus1BlockTimer = 0f;
								}
						}
						if (Random.value > 0.85f) {
								Instantiate (Earth, new Vector3 (position + 10.0f, 3f, 0f), gameObject.transform.rotation);
								if (Random.value > 0.90f && bonus1BlockTimer > bonus1BlockTimerSet) {
										Instantiate (Bonus1, new Vector3 (position + 10.0f, 3.7f, 0f), gameObject.transform.rotation);
										bonus1BlockTimer = 0f;
								}
						}


						//	if (Random.value > 0.85f) {
						//			Instantiate (Earth, new Vector3 (position + 10.0f, -2f, 0f), gameObject.transform.rotation);
						//	} 
				} else {
						timer -= Time.deltaTime;
						bonus1BlockTimer += Time.deltaTime;
				}
						
		}


}
