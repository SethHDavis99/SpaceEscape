using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_script : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = player.position + offset;
    }
}
