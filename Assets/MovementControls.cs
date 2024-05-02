using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{

    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        
        float horizonatalInput = 
    Input.GetAxis ("Horizontal");
        float verticalInput = 
    Input.GetAxis ("Vertical");

            Vector3 movement = new 
    Vector3(horizonatalInput, 0, verticalInput) 
    * speed * Time.deltaTime;

        transform.Translate(movement, 
    Space.World);

    }
}
