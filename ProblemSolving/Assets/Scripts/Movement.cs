using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    public float initialForce ;
    


    void PushBall()
    {
        float randomDir = Random.Range(0, 2);
        float randomSpeed = Random.Range(0, initialForce);
        if(randomDir < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(initialForce, -randomSpeed));
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(-randomSpeed, initialForce));
        }
        

    }

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Invoke("PushBall", 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
