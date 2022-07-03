using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 8F;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
