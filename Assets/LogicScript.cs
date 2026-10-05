using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    
    public GameObject gameOverScreen;

    private bool gameIsOver = false;

    public AudioSource gameover;

    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    } 
    public void restartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        if (gameIsOver)
        {
            return;
        }

        gameIsOver = true;
        Debug.Log("GAME OVER CHAMADO");
        gameOverScreen.SetActive(true);
    }
    public void playGameOverSound()
    {
        gameover.PlayOneShot(gameover.clip);
    }
}
