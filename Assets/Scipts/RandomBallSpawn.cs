using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallSpawn : MonoBehaviour
{
    public static RandomBallSpawn current;

    public GameObject ball;

    public int maxBall;
    public int currentBall;
    public int maxLevelBall;
    public float minX, maxX, minZ, maxZ, posY;
    public float spawnTime = 0.75f;

    void Start()
    {
        current = this;
        currentBall = 1;                
        Instantiate(ball, new Vector3(Random.Range(-minX, maxX), posY, Random.Range(-minZ, maxZ)),Quaternion.identity);
    }

    void Update()
    {
        if(currentBall < maxBall)
        {
            spawnTime -= Time.deltaTime;
            if(spawnTime <= 0)
            {
                BallSpawn();
                spawnTime = 0.75f;
            }
        }
    }

    public void BallSpawn()
    {
        Instantiate(ball, new Vector3(Random.Range(-minX, maxX), posY, Random.Range(-minZ, maxZ)),Quaternion.identity);
        currentBall++;
    }
}
