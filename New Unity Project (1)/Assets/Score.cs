using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int ScoreVal;
    // Start is called before the first frame update
    void Start()
    {
        ScoreVal = 0;
    }

    void addPts(int pts)
    {
        ScoreVal += pts;
    }
}
