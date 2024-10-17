using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    Vector2 direction = Vector2.right;
    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        float angle = 10.0f * Mathf.Cos(angle = 10.0f);
        direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > 9.4f)
        {
            direction.x = (-direction.x);
        }
        if (transform.position.y > 4.5f)
        {
            direction.y = (-direction.y);
        }
        if (transform.position.x < -9.4f)
        {
            direction.x = (-direction.x);
        }
        if (transform.position.y < -4.5f)
        {
            direction.y = (-direction.y);
        }


        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}