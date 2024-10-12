using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Rigidbody2D birdRigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        birdRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !GameManager.instance.isDead)
        {
            birdRigidBody.velocity = Vector2.up * speed;
        }
        transform.rotation = Quaternion.Euler(0, 0, birdRigidBody.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.facade.Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.instance.facade.PipePassed();
    }
}
