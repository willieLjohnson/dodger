using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    // bounds
    public float leftBound = -5F;
    public float rightBound = 5F;
    public float upBound = 3.5F;
    public float downBound = -3.5F;

    void Start()
    {
        
    }

    void Update()
    {
        float xMoveSpeed = Time.deltaTime * Input.GetAxis("Horizontal") * speed;   
        float yMoveSpeed = Time.deltaTime * Input.GetAxis("Vertical") * speed;   
        transform.Translate(xMoveSpeed, yMoveSpeed, 0);

        // create bounds
        if (transform.position.x > rightBound) {
            transform.position = new Vector3(rightBound, transform.position.y, 0);
        } else if (transform.position.x < leftBound) {
            transform.position = new Vector3(leftBound, transform.position.y, 0);
        }

        if (transform.position.y > upBound) {
            transform.position = new Vector3(transform.position.x, upBound, 0);
        } else if (transform.position.y < downBound) {
            transform.position = new Vector3(transform.position.x, downBound, 0);
        }
    }
}
