using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    public Button exitButton;
    // Start is called before the first frame update
    void Start()
    {
        Button button = exitButton.GetComponent<Button>();
        button.onClick.AddListener(OnClickProcedure);
    }

    // Update is called once per frame
    void OnClickProcedure()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
