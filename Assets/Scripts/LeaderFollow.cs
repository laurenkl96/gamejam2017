using System.Collections;
using UnityEngine;

public class LeaderFollow : MonoBehaviour
{
    public float moveSpeed;
    public Transform lead;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = lead.position - this.transform.position;
        direction.y = 0;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
        this.transform.Translate(0, 0, moveSpeed);
    }
}