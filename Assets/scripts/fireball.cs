using UnityEngine;

public class fireball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody fireballRB;
    public float speed = 5;
    public float destroyTimer = 1.5f;

    void Start()
    {
        fireballRB.linearVelocity = transform.forward * speed;
        Destroy(gameObject, destroyTimer);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
