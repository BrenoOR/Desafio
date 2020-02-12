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
    public float counterSide = 0f;
    float counterUpDown = 0f;
    public Text text;
    public ScoreChange scoreText;
    public int enemyValue;
    public bool movingDown;

    private void Start()
    {
        enemyValue = 10;
        if (movingLeft)
        {
            if (counterSide < -5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counterSide = counterSide - 0.01f;
            }
        }
        else
        {
            if (counterSide > 5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counterSide = counterSide + 0.01f;
            }
        }
    }

    private void Update()
    {
        if (movingLeft)
        {
            if (counterSide < -5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(-0.01f, 0, 0);
                counterSide = counterSide - 0.01f;
                if ((counterSide < -5f) && (counterSide > -5.1f))
                {
                    if (movingDown)
                    {
                        if (counterUpDown < -2f)
                        {
                            movingDown = !movingDown;
                        } else
                        {
                            startPos.transform.Translate(0, -0.1f, 0);
                            counterUpDown = counterUpDown - 0.1f;
                        }
                    } else
                    {
                        if (counterUpDown > 2f)
                        {
                            movingDown = !movingDown;
                        } else
                        {
                            startPos.transform.Translate(0, 0.1f, 0);
                            counterUpDown = counterUpDown + 0.1f;
                        }
                    }
                }
            }            
        }
        else
        {
            if (counterSide > 5f)
            {
                movingLeft = !movingLeft;
            }
            else
            {
                startPos.transform.Translate(0.01f, 0, 0);
                counterSide = counterSide + 0.01f;
                if ((counterSide > 5f) && (counterSide < 5.1f))
                {
                    if (movingDown)
                    {
                        if (counterUpDown < -2f)
                        {
                            movingDown = !movingDown;
                        }
                        else
                        {
                            startPos.transform.Translate(0, -0.1f, 0);
                            counterUpDown = counterUpDown - 0.1f;
                        }
                    }
                    else
                    {
                        if (counterUpDown > 2f)
                        {
                            movingDown = !movingDown;
                        }
                        else
                        {
                            startPos.transform.Translate(0, 0.1f, 0);
                            counterUpDown = counterUpDown + 0.1f;
                        }
                    }
                }
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
