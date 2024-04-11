using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro2ToGameplay : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Aisaguri Village Snow URP", LoadSceneMode.Single);
    }
}
