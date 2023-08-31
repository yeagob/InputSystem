using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key Donw & Up: Enter
        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado enter.");
        if (Input.GetKey(KeyCode.Return))
            print("Se está pulsando enter.");
        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha soltado enter.");

        //Other key
        if (Input.GetKeyUp(KeyCode.A))
            print("Se ha soltado A");
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            print("Se ha soltado left");
        if (Input.GetKeyUp(KeyCode.F1))
            print("Se ha soltado F1");
        if (Input.GetKeyUp(KeyCode.Space))
            print("Se ha soltado Space");
        if (Input.GetKeyUp(KeyCode.Escape))
            print("Se ha soltado Escape");
        if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt))
            print("Se ha soltado Alt ");
    }
}
