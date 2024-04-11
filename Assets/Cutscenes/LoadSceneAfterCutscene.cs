using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAfterCutscene : MonoBehaviour
{
    [SerializeField] private GameObject _cutscene;
    public GameObject cutsceneCamera;
    public string scene;

    void Start()
    {
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
                cutsceneCamera.SetActive(true);
                _cutscene.SetActive(true);
                StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(37);
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
        SceneManager.LoadScene(scene);
    }
}
