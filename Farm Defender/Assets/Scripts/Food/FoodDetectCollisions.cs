using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDetectCollisions : MonoBehaviour
{
    public HeartManegar playerManegar;
    [SerializeField] FoodType foodType;

    public enum FoodType
    {
        Apple,
        Bone,
        Carrot
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((foodType == FoodType.Apple && collision.gameObject.CompareTag("Cow")) ||
            (foodType == FoodType.Bone && collision.gameObject.CompareTag("Dog")) ||
            (foodType == FoodType.Carrot && collision.gameObject.CompareTag("Horse")))
        {
            Destroy(gameObject); 
            Destroy(collision.gameObject); 
        }
    }
}
