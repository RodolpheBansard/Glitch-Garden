using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private int delay = 3;
    int currentIndex;

    
    void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentIndex == 0)
        {
            StartCoroutine(SplashScreen());
        }
        

    }

    IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(delay);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndex + 1);
    }
}
