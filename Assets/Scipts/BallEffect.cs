using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEffect : MonoBehaviour
{

    public GameObject explosion;
    public static BallEffect current;
    void Start()
    {
        current = this;
    }

    public void ShowBallEffect(Vector3 pos)
    {
        Instantiate(explosion, pos, Quaternion.identity);
    }

}
