using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkCollisionScript : MonoBehaviour
{
    BoxCollider2D collider;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Input.mousePosition;

        // Convert it to "world-space" to match the coordinates of your game objects!
        mouse = Camera.main.ScreenToWorldPoint(mouse);

        // x & y are the centre of our rectangle (game object)
        float x = transform.position.x;
        float y = transform.position.y;
        float hw = collider.size.x * transform.localScale.x * 0.5f;
        float hh = collider.size.y * transform.localScale.y * 0.5f;

        // Use min & max values to do your point-rectangle test against the mouse!
        float xMin = x - hw;
        float xMax = x + hw;
        float yMin = y - hh;
        float yMax = y + hh;

        // Check our math by rendering lines!
        Debug.DrawLine(new Vector3(xMin, yMin), new Vector3(xMin, yMax), Color.red);
        Debug.DrawLine(new Vector3(xMax, yMin), new Vector3(xMax, yMax), Color.yellow);
        Debug.DrawLine(new Vector3(xMin, yMin), new Vector3(xMax, yMin), Color.blue);
        Debug.DrawLine(new Vector3(xMin, yMax), new Vector3(xMax, yMax), Color.green);

        if (mouse.x < xMin)
        {
            sr.color = Color.red;
        }
        else if (mouse.x > xMax)
        {
            sr.color = Color.red;
        }
        else if (mouse.y < yMin)
        {
            sr.color = Color.red;
        }
        else if (mouse.y > yMax)
        {
            sr.color = Color.red;
        }
        else
        {
            sr.color = Color.green;
        }
    }
}
