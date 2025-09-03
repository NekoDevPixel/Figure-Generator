using UnityEngine;
using UnityEngine.UI;

public class ShapeUI : MonoBehaviour
{
    // public Button Squre;
    // public Button Triangle;
    // public Button Circle;

    // public static ShapeUI instance { get; private set; }
    // void Start()
    // {
    //     if (instance != null)
    //     {
    //         Destroy(instance);
    //     }
    //     else
    //     {

    //     }
    // }

    public bool Sqb = false;
    public bool Trb = false;
    public bool Cib = false;

    public void Squrebtn()
    {
        Sqb = !Sqb;
    }

    public void Trianglebtn()
    {
        Trb = !Trb;
    }
    
    public void Circlebtn()
    {
        Cib = !Cib;
    }
}
