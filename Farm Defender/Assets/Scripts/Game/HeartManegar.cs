using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManegar : MonoBehaviour
{
    public static HeartManegar Instance { get; private set; }


    [Header("Heart")]
    public int totalHeart;
    

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


}
