using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AK.Wwise.Event StartEvent;
    public AK.Wwise.Event QuitEvent;
    public AK.Wwise.Event StopMusicEvent;


    public void PlayGame()
    {
        StartEvent.Post(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StopMusicEvent.Post(gameObject);
    }

    public void QuitGame()
    {
        QuitEvent.Post(gameObject);
        Application.Quit();
        StopMusicEvent.Post(gameObject);
    }
}
