using UnityEngine;

public class LeaderFollow : MonoBehaviour
{
    public float moveSpeed;
    public Transform lead;
    private Rigidbody rb;
    Vector3 pos;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.Normalize(lead.position - this.transform.position) * Time.deltaTime * moveSpeed;
        direction.y = 0;
        rb.MoveRotation(Quaternion.LookRotation(direction));
        rb.MovePosition(pos + new Vector3(direction.x, 0, direction.z));
        pos = GetComponent<Transform>().position;
    }
}