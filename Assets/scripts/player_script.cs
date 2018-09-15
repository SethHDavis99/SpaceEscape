using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_script : MonoBehaviour
{

    public float speed;

    void Update()
    {
        //look at mouse
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        //movement
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed, Space.World);
    }
}
