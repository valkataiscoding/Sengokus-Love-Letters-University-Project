using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateObjectivesList : MonoBehaviour
{
    public GameObject newObjective;
    public GameObject newObjectiveBackground;

    // Start is called before the first frame update
    void Start()
    {
        newObjective.SetActive(false);
        newObjectiveBackground.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            newObjective.SetActive(true);
            newObjectiveBackground.SetActive(true);
        }
    }
}
