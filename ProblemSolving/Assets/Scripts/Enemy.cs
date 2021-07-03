using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody;
    public GameObject gameObject;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Circle")
        {
            Destroy(gameObject);
            ScoreSystem.score += 1;
            RandomSpawner.countEnemy -= 1;
        }
    }
}
