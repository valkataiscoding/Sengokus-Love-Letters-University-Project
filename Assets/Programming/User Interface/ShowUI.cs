using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    [SerializeField]
    public GameObject yourText; // Insert your text object inside unity inspector
    public GameObject textBackGround;
    public GameObject triggerBox;

    void Start()
    {
        yourText.SetActive(false); // You may need to use .SetActive(false);
        textBackGround.SetActive(false);
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            yourText.SetActive(true);
            textBackGround.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
         yourText.SetActive(false);
        textBackGround.SetActive(false);
        Destroy(triggerBox);
    }
}
