using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawn : MonoBehaviour
{

    public GameObject prefab;
    private float Timer;
    float xRange;

    // Start is called before the first frame update
    void Start()
    {

        xRange = Random.Range(-50f, 50f);
        Timer = Time.time + 2.5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer < Time.time)
        { //This checks wether real time has caught up to the timer
            Instantiate(prefab, new Vector2(xRange, transform.position.y), transform.rotation);
            xRange = Random.Range(-50f, 50f);
            Timer = Time.time + 2.5f;
        }
    }
}
