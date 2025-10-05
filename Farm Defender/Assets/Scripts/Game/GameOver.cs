using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public HeartManegar playerManegar;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cow") || collision.gameObject.CompareTag("Dog") || collision.gameObject.CompareTag("Horse"))
        {
            Destroy(collision.gameObject);
            Heart();
        }
    }


    void Heart()
    {
        if (playerManegar.totalHeart > 0)
        {
            playerManegar.totalHeart -= 1;
        }

        else if (playerManegar.totalHeart <= 0)
        {
            playerManegar.totalHeart = 0;
            SceneManager.LoadScene(1);
        }
    }





}
