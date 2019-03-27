using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    public TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();

        if (Score == null)
        {
            Debug.Log("meh");
        }

    }

    // Update is called once per frame
    void Update()
    {
        Score.SetText("Score: {0}" , scoreValue);
        if (scoreValue == 25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Ucitava sledecu scenu koja je queue
        }
    }
}
