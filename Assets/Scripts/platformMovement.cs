using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public float speed;
    public float movementDuration;

    private float timer = 0;
    private bool isMovingRight = true;


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= movementDuration)
        {
            isMovingRight = !isMovingRight;
            timer = 0;
        }


        if (isMovingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
