using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Point(X-Z")]
    [SerializeField] float xPoint;
    [SerializeField] float zPoint;

    [Space]

    [Header("Player Speed")]
    [SerializeField] float playerSpeed;



    private void Update()
    {
        MovePlayer();
        BorderLimit();     
    }

    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * playerSpeed * horizontal * Time.deltaTime);
        transform.Translate(Vector3.forward * playerSpeed * vertical * Time.deltaTime);
    }

    void BorderLimit()
    {
        //x Limit
        if (gameObject.transform.position.x > xPoint)
        {
            transform.position = new Vector3(xPoint, transform.position.y, transform.position.z);
        }

        else if (gameObject.transform.position.x < -xPoint)
        {
            transform.position = new Vector3(-xPoint, transform.position.y, transform.position.z);
        }


        //Z Limit
        if (gameObject.transform.position.z > zPoint)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zPoint);
        }

        else if (gameObject.transform.position.z < -zPoint)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zPoint);
        }
    }



    
}
