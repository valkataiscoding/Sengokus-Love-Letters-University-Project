using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUIText : MonoBehaviour
{
    [SerializeField]
    public GameObject text;

    void Start()
    {
        text.SetActive(true);
    }

    void Update()
    {
        StartCoroutine(RemoveText());
    }


    IEnumerator RemoveText()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }
}
