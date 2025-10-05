using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public HeartManegar heartManegar;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cow") ||
            collision.gameObject.CompareTag("Dog") ||
            collision.gameObject.CompareTag("Horse"))
        {
            
            Destroy(collision.gameObject);
            heartManegar.totalHeart -= 1;
        }
    }
}
