using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCharacterConvoMultiple : MonoBehaviour
{
    public GameObject[] text;
    //public GameObject trigger;

    private void Start()
    {
        for (int i = 0; i < text.Length; i++)
        {
            Debug.Log("false");
            text[i].SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < text.Length; i++)
            {
                StartCoroutine(ActivateText());
            }
        }
    }
    public void WaitAndDisable(GameObject obj)
    {
        StartCoroutine(WaitAndDisableCoroutine(obj));
    }

    IEnumerator WaitAndDisableCoroutine(GameObject obj)
    {
        yield return new WaitForSeconds(5f);
        obj.SetActive(false);
    }

    private IEnumerator ActivateText()
    {
        WaitForSeconds wait = new WaitForSeconds(5f);
        foreach (GameObject t in text)
        {
            t.SetActive(true);
            yield return wait;
            t.SetActive(false);
        }
    }
}
