using UnityEngine;

public class MoveSP : MonoBehaviour
{
    private Vector2 mousePos;
    private GameObject selectobject;
    private bool mvchck = false;
    Collider2D hit;
    

    void Update()
    {
        CheckCollider();
    }

    void FixedUpdate()
    {
        moveShape();
    }

    void CheckCollider()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.OverlapPoint(mousePos);

            if (hit != null)
            {
                selectobject = hit.gameObject;
                mvchck = !mvchck;
            }
            else
            {
                selectobject = null;
                mvchck = false;
            }
        }
    }

    void moveShape()
    {
        if (mvchck)
        {
            selectobject.transform.position = mousePos;
        }
    }

    
}
