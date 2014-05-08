using UnityEngine;
using System.Collections;

public class player_death : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Player != null) {		
		if	(Player.transform.position.y <= -5f){
				Destroy (Player);

			}
	}
	}}
