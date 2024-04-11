using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneTrigger : MonoBehaviour
{
    public GameObject thePlayer;
    [SerializeField]
    public GameObject cutsceneCam;
    public GameObject locationGUI;

    void Start()
    {
        locationGUI.SetActive(false);
    }

    void OnTriggeEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
        yield return new WaitForSeconds(20);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }

    void OnTriggerExit()
    {
        locationGUI.SetActive(false);
    }
}