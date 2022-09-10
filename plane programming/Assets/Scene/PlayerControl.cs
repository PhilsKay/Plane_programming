using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 50.0f;
    private float turnSpeed = 15.0f;
    private float horizontalControl;
    private float verticalControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalControl = Input.GetAxis("Horizontal");
        verticalControl = Input.GetAxis("Vertical");
        //Move the plane forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalControl);
        if(horizontalControl != 0)
        {
            //Rotate the plae up/down
            transform.Rotate(Vector3.left, Time.deltaTime * speed * verticalControl);
        }
        
    }
}
