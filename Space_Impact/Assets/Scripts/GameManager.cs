using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float DeathDelay = 1.5f;
    public GameObject DeathMenuUI;
    public GameObject CompleteGame;
    // Update is called once per frame
    void Update()
    {
        if (!Player.player.gameObject.activeSelf) //Smrt igraca i reload
        {
            Death();
        }
        if (BossScript.health == 0)
        {
            BossScript.health = 1;
            Invoke("WonGame", 1f);
        }
    }

    public void WonGame()
    {
        CompleteGame.SetActive(true);
    }

    void Death()
    {
        Invoke("DeathMenu", DeathDelay);
    }

    void DeathMenu()
    {
        DeathMenuUI.SetActive(true);
    }

    public void Restart()
    {
        ScoreScript.scoreValue = 0;
        BossScript.health = 20;
        CompleteGame.SetActive(false);
        DeathMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Izasoo iz igricu!");
        Application.Quit();
    }

    public void LoadMenu()
    {
        ScoreScript.scoreValue = 0;
        BossScript.health = 20;
        CompleteGame.SetActive(false);
        DeathMenuUI.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
