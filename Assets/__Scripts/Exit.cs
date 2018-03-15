using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
	public Dray dray;
	private SphereCollider drayColld;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find("Dray");
        dray = go.GetComponent<Dray>();
		drayColld = go.GetComponent<SphereCollider>();
	}
	
	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.name == "Dray") {
			SceneManager.LoadScene(SceneManager.sceneCount + 1);
		}
	}
}
