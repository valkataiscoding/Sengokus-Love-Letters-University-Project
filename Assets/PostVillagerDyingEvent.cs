using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostVillagerDyingEvent : MonoBehaviour
{
    public AK.Wwise.Event MyEvent;
    // Start is called before the first frame update
    public void PlayVillagerDying()
    {
        MyEvent.Post(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
