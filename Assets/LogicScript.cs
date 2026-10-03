using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    
    public GameObject gameOverScreen;


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
        Debug.Log("GAME OVER CHAMADO");
        gameOverScreen.SetActive(true);
    }
}
