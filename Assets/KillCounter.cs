using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public static int score;
    private ShootArrow shootArrow;

    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        shootArrow = GameObject.FindObjectOfType<ShootArrow>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score = shootArrow.score;
        text.text = "Kill 50 Bandits: " + score + "/50";
    }
}
