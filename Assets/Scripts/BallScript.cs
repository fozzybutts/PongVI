using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
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
        // Ball Reset Position
        // gameObject.transform.position = new Vector3(0.52f, -0.51f, 0f);
      
        if (transform.position.y > 4.2f)
        {
            direction.y = (-direction.y);
        }
       
        if (transform.position.y < -5.0f)
        {
            direction.y = (-direction.y);
        }
        
        if (transform.position.x > 10.3f)
        {
            gameObject.transform.position = new Vector3(0.52f, -0.51f, 0f);
        }
       
        if (transform.position.x < -9.3f)
        {
            gameObject.transform.position = new Vector3(0.52f, -0.51f, 0f);
        }


        float dt = Time.deltaTime;
        Vector3 change = direction * speed * dt;
        transform.position = transform.position + change;
    }
}