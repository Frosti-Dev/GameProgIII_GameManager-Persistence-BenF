using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScreenScript : MonoBehaviour
{
    public static TraverseScreenScript player;

    void Awake()
    {
        if (player == null)
        {
            DontDestroyOnLoad(gameObject);
            player = this;
        }

        else if (player != null)
        {
            Destroy(gameObject);
        }
    }

    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level" +  level);
    }

    public void OnSpace()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnOne()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnTwo()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OnThree()
    {
        SceneManager.LoadScene("Level3");
    }

}
