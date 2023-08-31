using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    //Attributes
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse / Touch
        if (Input.GetMouseButtonUp(0))
            print("Boton iz");
        if (Input.GetMouseButtonUp(1))
            print("Boton der");
        if (Input.GetMouseButtonUp(2))
            print("Boton centre");

        //Mouse posion
        print("Mouse x: " + Input.mousePosition.x +" / Mouse y:" + Input.mousePosition.y + " / z: "+ Input.mousePosition.z);

        target.position = Input.mousePosition;
    }
}
