using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBackHomeObjective : MonoBehaviour
{
    [SerializeField]
    public GameObject currentObjective;
    public GameObject currentObjectiveBackGround;
    // Start is called before the first frame update
    void Start()
    {
        currentObjective.SetActive(true);
        currentObjectiveBackGround.SetActive(true);
    }

    void Update()
    {
        StartCoroutine(AddCurrentObjective());
    }

    IEnumerator AddCurrentObjective()
    {
        yield return new WaitForSeconds(3);
        currentObjective.SetActive(false);
        currentObjectiveBackGround.SetActive(false);
    }
}
