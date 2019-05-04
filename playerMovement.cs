using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Console log Debug message");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,10);
    }
}
