using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToGameplay : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Aisaguri Village 1 URP", LoadSceneMode.Single);
    }
}
