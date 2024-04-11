using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCutscene : MonoBehaviour
{
    [SerializeField] private GameObject _cutscene;
    public GameObject cutsceneCamera;
    public GameObject mainCamera;

    void Start()
    {
        //mainCamera.SetActive(true);
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
                //mainCamera.SetActive(false);
                cutsceneCamera.SetActive(true);
                _cutscene.SetActive(true);
                StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(14);
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
        mainCamera.SetActive(true);
    }
}
