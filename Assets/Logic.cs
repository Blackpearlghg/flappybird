using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerscore = 0;
    public Text scoretext;
    public GameObject gameover;
    public GameObject bird;
    public GameObject pillar;
    public GameObject logic;
    public GameObject play;
    public Rigidbody2D myrigidbody;

    public void gamestart()
    {
        bird.SetActive(true);
        pillar.SetActive(true);
        logic.SetActive(true);
        play.SetActive(false);
    }
    public void addscore(int a)
    {
        playerscore = playerscore + a;
        scoretext.text = playerscore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover1()
    {
        gameover.SetActive(true);
        
    }
    public void gamepause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            bird.SetActive(false);
            pillar.SetActive(false);
        }
    }
}
