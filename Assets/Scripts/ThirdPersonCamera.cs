using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {
    public GameObject player;
    Vector3 offset;

    //Start is used at initiallization
    void Start()
    {
        offset = player.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        float angle = player.transform.eulerAngles.y;
        Quaternion rot = Quaternion.Euler(0, angle, 0);
        transform.position = player.transform.position - (rot * offset);
        transform.LookAt(player.transform);
	}
}
