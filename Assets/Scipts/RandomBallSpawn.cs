using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallSpawn : MonoBehaviour
{
    public static RandomBallSpawn current;

    public GameObject ball;

    public int maxBall;
    public float minX, maxX, minZ, maxZ, posY;
    public float spawnTime = 0.75f;

    public int ballNumber;
    public List<GameObject> spawnedBall;

    void Start()
    {
        current = this;
    }

    void Update()
    {
        if(spawnedBall.Count < maxBall)
        {
            spawnTime -= Time.deltaTime;
            if(spawnTime <= 0)
            {
                GameObject tempObject;
                tempObject = Instantiate(ball, new Vector3(Random.Range(-minX, maxX), posY, Random.Range(-minZ, maxZ)),Quaternion.identity);
                tempObject.name = "Clone Ball" + ballNumber;
                ballNumber++;
                spawnedBall.Add(tempObject);
                spawnTime = 0.75f;
            }
        }
    }
}
