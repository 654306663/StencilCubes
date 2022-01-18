using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float speed = 1;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0,speed,0));
	}
}
