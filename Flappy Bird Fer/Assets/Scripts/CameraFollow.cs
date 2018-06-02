using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    // seguiendo
    public Transform elDesgraciado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(elDesgraciado.position.x, this.transform.position.y, this.transform.position.z);
	}
}
