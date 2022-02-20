using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    public float lerpLimit;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Player.position + offset, Time.deltaTime * lerpLimit);
        float xPos = Mathf.Clamp(transform.position.x, -6.75f, 6.75f);
        float zPos = Mathf.Clamp(transform.position.z, -19, 1);
        transform.position = new Vector3(xPos, transform.position.y, zPos);
    }
}
