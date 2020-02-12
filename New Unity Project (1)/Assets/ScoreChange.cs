using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreChange : MonoBehaviour
{
    public int score;

    Text text;

    public GameObject scene;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score;
        if (score == 320)
        {
            SceneManager.LoadScene("EndGame", LoadSceneMode.Single);
        }
    }
}
