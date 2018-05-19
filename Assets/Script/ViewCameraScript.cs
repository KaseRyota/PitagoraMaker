﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.gameObject.transform.position += new Vector3(-0.1f, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.gameObject.transform.position += new Vector3(-0.1f, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            this.gameObject.transform.position += new Vector3(0.1f, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            this.gameObject.transform.position += new Vector3(0.1f, 0, -0.1f);
        }
    }
}
