using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    float leftSide;
    float rightSide;
    float topSide;
    float bottomSide;
    float movementSpeed;
    float horiMovement;
    float vertMovement;
    float jumpHeight = 15f;
    Rigidbody playerRB;



    // Start is called before the first frame update
    void Start()
    {
        movementSpeed=5;
        playerRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        horiMovement=Input.GetAxis("Horizontal");
        vertMovement=Input.GetAxis("Vertical");

        transform.Translate(horiMovement*Time.deltaTime*movementSpeed, 0, 0);
        transform.Translate(0, vertMovement*Time.deltaTime*movementSpeed, 0);

        //transform.Translate(movementSpeed, 0, 0);
        if (Input.GetButtonDown("Jump"))
        {

            playerRB.AddForce(Vector3.up*jumpHeight,ForceMode.Impulse);
        }

       

    }
}
