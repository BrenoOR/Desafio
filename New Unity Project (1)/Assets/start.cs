using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Button button = startButton.GetComponent<Button>();
        button.onClick.AddListener(OnClickProcedure);
    }

    void OnClickProcedure()
    {
        Debug.Log("Game start!");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
