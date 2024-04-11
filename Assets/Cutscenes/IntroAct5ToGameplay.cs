using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroAct5ToGameplay : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Act 5 Aisaguri Village", LoadSceneMode.Single);
    }
}
