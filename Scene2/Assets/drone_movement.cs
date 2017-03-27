using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * Time.deltaTime * 31*2);
        transform.Translate(Vector3.down * Time.deltaTime * 3*2);
    }
}
