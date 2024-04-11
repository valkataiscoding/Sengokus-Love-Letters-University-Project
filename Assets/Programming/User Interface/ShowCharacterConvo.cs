using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCharacterConvo : MonoBehaviour
{
    public GameObject text;
    public GameObject trigger;

    private void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.SetActive(true); //this text need to be displayed for 5 seconds after destroying game object
            WaitAndDisable(text); // here we go ;)
            //Destroy(this.gameObject);
            //Destroy(other);
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
        Destroy(trigger);
    }
}
