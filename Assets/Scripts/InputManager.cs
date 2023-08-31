using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Attributes
    public Transform cubeTransform;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MOuse Axis Debug
        //Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Mouse Y"), Color.red);
         //Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Mouse X"), Color.blue);

        //keyboar axis debug
        Debug.DrawRay(cubeTransform.position, Vector3.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, Vector3.forward * Input.GetAxis("Vertical"), Color.blue);

        //Button
        if (Input.GetButtonUp("Fire1"))
        {
            print("Fire!!");
		}

        //Mouse Wheel
        print("Mouse wheel: " + Input.GetAxis("Mouse ScrollWheel"));

        //Movement by Mouse
        cubeTransform.Translate(Vector3.right* Input.GetAxis("Mouse X") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Mouse Y") * Time.deltaTime * speed);

        //Movement by keys
        cubeTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        cubeTransform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
