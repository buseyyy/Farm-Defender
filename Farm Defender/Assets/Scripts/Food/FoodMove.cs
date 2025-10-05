using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{
    [Header("Food Speed")]
    [SerializeField] float foodSpeed;

    [Header("Destroy Time")]
    [SerializeField] float timeDestroyFood = 10;

    private void Update()
    {
        MoveFood();
        FoodDestroy();
    }

    void MoveFood()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * foodSpeed);
    }


    void FoodDestroy()
    {
        Destroy(gameObject, timeDestroyFood);
    }

   
}
