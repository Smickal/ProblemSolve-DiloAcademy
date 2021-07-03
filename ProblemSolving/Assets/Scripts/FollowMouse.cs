using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 MousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rigidbody2D;
    Vector2 position = new Vector2(0f, 0f);


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MousePosition = Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
        position = Vector2.Lerp(transform.position, MousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(position);
    }
}
