using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowObjectives : MonoBehaviour
{
    [SerializeField]
    public GameObject objectives;
    public GameObject[] objectivesToShow;
    public GameObject objectivesBackGround;

    public GameObject currentObjective;
    public GameObject currentObjectiveBackGround;

    void Start()
    {
        objectivesBackGround.SetActive(false);
        objectives.SetActive(false);
        currentObjective.SetActive(true);
        currentObjectiveBackGround.SetActive(true);
        for (int i = 0; i < objectivesToShow.Length; i++)
        {
            objectivesToShow[i].SetActive(false);
        }

    }

    void Update()
    {
        StartCoroutine(AddCurrentObjective());
        StartCoroutine(AddText());
    }


    IEnumerator AddText()
    {
        yield return new WaitForSeconds(3);
        objectives.SetActive(true);
        objectivesBackGround.SetActive(true);
        for (int i = 0; i < objectivesToShow.Length; i++)
        {
            objectivesToShow[i].SetActive(true);
        }
    }

    IEnumerator AddCurrentObjective()
    {
        yield return new WaitForSeconds(3);
        currentObjective.SetActive(false);
        currentObjectiveBackGround.SetActive(false);
    }
}
