using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStart : MonoBehaviour
{
    [SerializeField]
    public GameObject tutorialText;
    public GameObject objectives;
    public GameObject[] objectivesToShow;
    //public GameObject currentObjective;

    public GameObject tutorialBackGround;
    public GameObject objectivesBackGround;

    void Start()
    {
        tutorialText.SetActive(true);
        objectives.SetActive(false);
        for (int i = 0; i < objectivesToShow.Length; i++)
        {
            objectivesToShow[i].SetActive(false);
        }
        //currentObjective.SetActive(false);
        tutorialBackGround.SetActive(true);
    }

    void Update()
    {
        StartCoroutine(RemoveTutorialText());
        StartCoroutine(AddObjectives());
        //StartCoroutine(AddCurrentObjective());
       // StartCoroutine(RemoveCurrentObjective());
    }

    //IEnumerator AddCurrentObjective()
    //{
    //    yield return new WaitForSeconds(10);
    //    currentObjective.SetActive(true);   
    //}

    //IEnumerator RemoveCurrentObjective()
    //{
    //    yield return new WaitForSeconds(3);
    //    currentObjective.SetActive(false);
    //}

    IEnumerator AddObjectives()
    {
        yield return new WaitForSeconds(12);
        objectives.SetActive(true);
        for (int i = 0; i < objectivesToShow.Length; i++)
        {
            objectivesToShow[i].SetActive(true);
        }
        objectivesBackGround.SetActive(true);
    }

    IEnumerator RemoveTutorialText()
    {
        yield return new WaitForSeconds(9);
        tutorialText.SetActive(false);
        tutorialBackGround.SetActive(false);
    }
}
