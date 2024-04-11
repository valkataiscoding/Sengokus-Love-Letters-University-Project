using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro4ToGameplay : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Aisaguri Village", LoadSceneMode.Single);
    }
}
