using UnityEngine;

public class CreateShape : MonoBehaviour
{
    Vector3 vector3;
    private ShapeUI shapeUI;
    public Transform Shape;

    [Header("생성될 도형")]
    public GameObject[] shape;

    [Header("생성 필드")]
    public GameObject Field;
    private Collider2D FieldC;
    public Rigidbody2D Frb;

    void Awake()
    {
        FieldC = Field.GetComponent<Collider2D>();
        shapeUI = FindFirstObjectByType<ShapeUI>();
    }

    void Update()
    {
        
        NewShape();
    }

    void RandomSP(GameObject gameObject)
    {
        Bounds bounds = FieldC.bounds;
        Vector2 Position = new Vector2(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y)
        );

        if (FieldC.OverlapPoint(Position))
        {
            Instantiate(gameObject, Position, Quaternion.identity, Shape);
        }
    }

    void NewShape()
    {
        if (shapeUI.Sqb)
        {
            Debug.Log("Click-S");
            RandomSP(shape[0]);
            shapeUI.Sqb = false;
        }
        if (shapeUI.Trb)
        {
            Debug.Log("Click-T");
            RandomSP(shape[1]);
            shapeUI.Trb = false;
        }
        if (shapeUI.Cib)
        {
            Debug.Log("Click-C");
            RandomSP(shape[2]);
            shapeUI.Cib = false;
        }
    }
}
