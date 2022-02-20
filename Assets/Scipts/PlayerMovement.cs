using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        if
        (
            direction.x == 0.0f && 
            direction.y == 0.0f && 
            direction.z == 0.0f
        ) 
        return;
        rb.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));
        transform.rotation = Quaternion.LookRotation(direction);
    }
}