using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjectivesUI : MonoBehaviour
{
    [SerializeField]
    public GameObject objectives;
    public GameObject firstObjective;

    void Start()
    {
        objectives.SetActive(false);
        firstObjective.SetActive(false);
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectives.SetActive(true);
            firstObjective.SetActive(true);
        }
    }
}