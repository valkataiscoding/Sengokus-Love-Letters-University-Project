using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public AK.Wwise.Event MyEvent;
    // Start is called before the first frame update
    public void PlayMoveToNextScene()
    {
        MyEvent.Post(gameObject);

    }
    void Start()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
