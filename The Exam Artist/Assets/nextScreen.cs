using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextScreen : MonoBehaviour
{
    
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void previousScene()
    {
        Debug.Log("I am called ");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
