using UnityEngine;

public class CreateShape : MonoBehaviour
{
    Vector3 vector3;
    private ShapeUI shapeUI;
    public Transform Shape;

    public GameObject Sq;
    public GameObject Tr;
    public GameObject Ci;

    void Awake()
    {
        shapeUI = FindFirstObjectByType<ShapeUI>();
    }

    void Update()
    {
        vector3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        NewShape();
    }



    void NewShape()
    {
        if (shapeUI.Sqb)
        {
            Debug.Log("Click-S");
            Instantiate(Sq, vector3, Quaternion.identity, Shape);
            shapeUI.Sqb = false;
        }
        if (shapeUI.Trb)
        {
            Debug.Log("Click-T");
            shapeUI.Trb = false;
        }
        if (shapeUI.Cib)
        {
            Debug.Log("Click-C");
            shapeUI.Cib = false;
        }
    }
}
