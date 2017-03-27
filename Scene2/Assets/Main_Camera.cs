using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Camera : MonoBehaviour {
    // Use this for initialization
    public Vector3 bar;
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        bar = GameObject.Find("man_5").transform.position;
        //transform.RotateAround(bar, Vector3.up, 20 * Time.deltaTime);
    }
}
