using UnityEngine;
using UnityEngine.SceneManagement;

public class TraverseScreenScript : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene("Level" +  level);
    }

}
