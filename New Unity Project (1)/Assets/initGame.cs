using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class initGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        } else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
