using UnityEngine;

public class HazardMove : MonoBehaviour
{
    // Variables
    public Rigidbody2D rb;
    public float turnspeed = 5f;
    private Vector3 rotatedirection;
    public GameManager GM;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //graft ridigbody to object
        rb = GetComponent<Rigidbody2D>();
        turnspeed = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
       rb.transform.Rotate(0f,0f,turnspeed);
    }
}

