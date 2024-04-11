using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act4Ending : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("IntroAct5", LoadSceneMode.Single);
    }
}
