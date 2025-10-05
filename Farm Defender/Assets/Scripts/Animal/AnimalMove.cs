using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    [Header("Animal Speed")]
    [SerializeField] float animalSpeed;


    private void Update()
    {
        transform.Translate(Vector3.forward * animalSpeed * Time.deltaTime);
    }

}
