using UnityEngine;

public class AdjustScript : MonoBehaviour
{
    private void OnGUI()
    {
        if(GUI.Button(new Rect(10,160,100,30), "Health up"))
        {
            GameManager.manager.health += 10;
        }
        if (GUI.Button(new Rect(10, 200, 100, 30), "Health down"))
        {
            GameManager.manager.health -= 10;

        }
        if (GUI.Button(new Rect(10, 240, 100, 30), "Exp up"))
        {
            GameManager.manager.exp += 100;

        }
        if (GUI.Button(new Rect(10, 280, 100, 30), "Exp down"))
        {
            GameManager.manager.exp -= 100;
        }
        if (GUI.Button(new Rect(10, 320, 100, 30), "Score up"))
        {
            GameManager.manager.score += 100;
        }
        if (GUI.Button(new Rect(10, 360, 100, 30), "Score down"))
        {
            GameManager.manager.score -= 100;
        }
        if (GUI.Button(new Rect(10, 400, 100, 30), "Attack up"))
        {
            GameManager.manager.atk += 10;
        }
        if (GUI.Button(new Rect(10, 440, 100, 30), "Attack down"))
        {
            GameManager.manager.atk -= 10;
        }
        if (GUI.Button(new Rect(10, 480, 100, 30), "Defense up"))
        {
            GameManager.manager.def += 10;
        }
        if (GUI.Button(new Rect(10, 520, 100, 30), "Defense down"))
        {
            GameManager.manager.def -= 10;
        }

        if (GUI.Button(new Rect(10, 580, 100, 30), "Save"))
        {
            GameManager.manager.Save();
        }
        if (GUI.Button(new Rect(10, 620, 100, 30), "Load"))
        {
            GameManager.manager.Load();
        }
    }
}
