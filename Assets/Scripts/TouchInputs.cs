using UnityEngine;

public class TouchInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.touchCount: Cantidad de dedos en la pantalla
        //Input.GetTouch(0): Nos da el toque pricnipal
        //TouchPhase.Began: Down, cuando iniciamos el toque
        //TouchPhase.Ended: Up, cuando dejamos de tocar
        //TouchPhase.Canceled: Si se cancela el toque
        //TouchPhase.Moved: si está en movimiento.
        //TouchPhase.Stationary: toque en un punto sin movimiento
    }
}
