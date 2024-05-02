using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControls : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float jumpPower = 150;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower);
        }
    }
}
