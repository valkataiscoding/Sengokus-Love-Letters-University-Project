using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraAnimationTrigger : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public GameObject locationGUI;

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

    //void OnTriggerEnter(Collider other)
    //{
    //    this.gameObject.GetComponent<BoxCollider>().enabled = false;
    //    //
    //    cutsceneCam.SetActive(true);
    //    thePlayer.SetActive(false);
    //    StartCoroutine(FinishCut());
    //}

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(8);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }

    void OnTriggerExit()
    {
        locationGUI.SetActive(false);
    }
}
