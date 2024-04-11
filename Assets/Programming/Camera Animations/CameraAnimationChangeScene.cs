using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraAnimationChangeScene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject locationGUI;
    public string scene;

    void Start()
    {
        locationGUI.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            locationGUI.SetActive(true);
            if (locationGUI.activeInHierarchy == true && Input.GetKeyDown(KeyCode.F))
            {
                locationGUI.SetActive(false);
                cutsceneCam.SetActive(true);
                thePlayer.SetActive(false);
                StartCoroutine(FinishCut());
            }
        }
    }
    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(8);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        SceneManager.LoadScene(scene);
    }
}
