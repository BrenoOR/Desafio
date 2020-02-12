using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -8.5f)
            {
                transform.Translate(-0.05f, 0, 0);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 8.5f)
            {
                transform.Translate(0.05f, 0, 0);
            }
        } else if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
        }
    }
}
