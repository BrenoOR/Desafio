using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollTwoMove : MonoBehaviour
{
    public Transform startPos;
    public bool movingRight;
    public float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (movingRight)
        {
            if (counter > 5f)
            {
                movingRight = !movingRight;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counter = counter + 0.01f;
            }
        }
        else
        {
            if (counter < -5f)
            {
                movingRight = !movingRight;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counter = counter - 0.01f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            if (counter > 5f)
            {
                movingRight = !movingRight;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counter = counter + 0.01f;
            }
        }
        else
        {
            if (counter < -5f)
            {
                movingRight = !movingRight;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counter = counter - 0.01f;
            }
        }
    }
}
