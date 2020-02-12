using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyLife : MonoBehaviour
{
    public Transform startPos;
    public int vida = 100;
    public Animator explosao;
    public bool movingLeft;
    public float counter = 0f;
    public Text text;
    public ScoreChange scoreText;
    public int enemyValue;

    private void Start()
    {
        enemyValue = 10;
        if (movingLeft)
        {
            if (counter < -5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counter = counter - 0.01f;
            }
        }
        else
        {
            if (counter > 5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counter = counter + 0.01f;
            }
        }
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (counter < -5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counter = counter - 0.01f;
            }
        }
        else
        {
            if (counter > 5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counter = counter + 0.01f;
            }
        }
    }

    public void Dano(int dano)
    {
        vida -= dano;
        if (vida <= 0)
        {
            Morte();
            getPoints(enemyValue);
        }
    }

    void Morte()
    {
        Instantiate(explosao, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void getPoints(int pts)
    {
        scoreText.score = scoreText.score + pts;
    }
}
