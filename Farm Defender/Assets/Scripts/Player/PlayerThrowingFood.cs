using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrowingFood : MonoBehaviour
{

    [SerializeField] GameObject[] foodPrefab;
    [SerializeField] KeyCode[] keys = { KeyCode.Q, KeyCode.E, KeyCode.R };


    private void Update()
    {
        CheckAndThrowFood();
    }

    void CheckAndThrowFood()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (Input.GetKeyDown(keys[i]))
            {
                GameObject food = Instantiate(foodPrefab[i], transform.position, foodPrefab[i].transform.rotation);
                
            }
        }
    }
}
