using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    public int Lives = 5;
    public int Score;
    public float TotalTime;
    public TextMeshProUGUI LivesLabel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI TimeLabel;

    void Update()
    {
        TotalTime += Time.deltaTime;

        LivesLabel.text = "Lives:\t" + Lives;
        ScoreLabel.text = "Score:\t" + Score;
        TimeLabel.text = "Time:\t" + (float)((int)(TotalTime*10)/10) + "s";
    }

    public void kill()
    {
        Lives--;
        if (Lives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }    
    }

    public void Collect()
    {
        Score += 10;
        if (Score % 100 == 0)
        {
            Lives++;
        }
    }
}
