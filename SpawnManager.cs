using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spanwPos = new Vector3(25, 0, 0);
    private float srtTime = 0;
    private float rptRate = 2.0f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", srtTime, rptRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacles()
    {
        if(playerControllerScript.gameOver == false)
            Instantiate(obstaclePrefab, spanwPos, obstaclePrefab.transform.rotation);
    }
}
