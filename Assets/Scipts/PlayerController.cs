using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int score;
    public Animator scoreTextClip;

    public static PlayerController current;

    void Start()
    {
        score = 0;    
        current = this;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "ball")
        {
            BallEffect.current.ShowBallEffect(other.transform.position);
            score += 10;
            scoreTextClip.Play(0);
            Destroy(other.gameObject, 0.25f);
            if(RandomBallSpawn.current.currentBall == 5)
            {
                RandomBallSpawn.current.currentBall--;
            }
        }
    }
}
