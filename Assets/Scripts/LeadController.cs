using UnityEngine;
using System.Collections;

public class LeadController : MonoBehaviour {
    public float speed = 10;
    public float turnSpeed = 60;
    
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; // turns player left or right
        transform.Rotate(0, h, 0);

        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime; // moves player back or forwards
        transform.Translate(0, 0, v);
    }
}
