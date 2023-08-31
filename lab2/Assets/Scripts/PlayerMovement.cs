using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    public float forceStrength = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Grabs the component RigidBody from the gameobject that is running the player
        rigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rigidBody.AddForce(new Vector3(-verticalInput,0, horizontalInput) * forceStrength);
    }
}
