using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro3ToGameplay : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("Aisaguri Village 2 Night URP", LoadSceneMode.Single);
    }
}
