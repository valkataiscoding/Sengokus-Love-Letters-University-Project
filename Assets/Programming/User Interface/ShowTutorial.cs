using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    [SerializeField]
    public GameObject tutorialText;

    void Start()
    {
        tutorialText.SetActive(true);
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutorialText.SetActive(false);
        }
    }
}
