using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act3FinalScene : MonoBehaviour
{

    [SerializeField] private GameObject _cutscene;
    public GameObject cutsceneCamera;
    public string scene;

    public GameObject[] bandits;

    void Start()
    {
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < bandits.Length; i++)
            {
                Destroy(bandits[i]);
            }

            cutsceneCamera.SetActive(true);
            _cutscene.SetActive(true);
            StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(32);
        cutsceneCamera.SetActive(false);
        _cutscene.SetActive(false);
        SceneManager.LoadScene(scene);
    }
}
