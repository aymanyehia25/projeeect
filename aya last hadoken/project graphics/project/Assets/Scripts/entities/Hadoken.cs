using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hadoken : MonoBehaviour {

    public fighter caster;
    private Rigidbody body;
    private float creationtime;
	// Use this for initialization
	void Start () {
        creationtime = Time.time;
        body = GetComponent<Rigidbody>();
        body.AddRelativeForce(new Vector3(200, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time - creationtime >3)
        {
            Destroy(gameObject);
        }
	}
}
