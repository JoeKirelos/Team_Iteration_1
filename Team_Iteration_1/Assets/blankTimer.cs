using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blankTimer : MonoBehaviour
{

    public Text Blast;
    public float cooldown;
    public float cooldownRefresh;
    public float blankStart;
    public float display;

    public GameObject player;
 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        blankStart = player.GetComponent<Player>().blankStart;
        cooldown = player.GetComponent<Player>().blankCD;
        cooldownRefresh = blankStart + cooldown;

        if (Time.time < blankStart + cooldown)
        {
            display = cooldownRefresh - Time.time;

        }

        Blast.text = "Blank Cooldown:   " + display;

        //    if (Input.GetKeyDown("space") && cooldownRefresh < 0)
        //    {
        //        cooldownRefresh = 0;
        //    }



    
    }
}
