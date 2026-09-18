using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public float health;
    public float exp;
    public float score;
    public float atk;
    public float def;

    void Awake()
    {
        if(manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }

        else if (manager != null)
        {
            Destroy(gameObject);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 50), "Health: " + health);
        GUI.Label(new Rect(10, 40, 150, 50), "EXP: " + exp);
        GUI.Label(new Rect(10, 70, 150, 50), "Score: " + score);
        GUI.Label(new Rect(10, 100, 150, 50), "Attack: " + atk);
        GUI.Label(new Rect(10, 130, 150, 50), "Defense: " + def);
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.health = health;
        data.exp = exp;
        data.score = score;
        data.atk = atk;
        data.def = def;


        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            exp = data.exp;
            score = data.score;
            atk = data.atk;
            def = data.def;
        }
    }

    [Serializable]
    class PlayerData
    {
        public float health;
        public float exp;
        public float score;
        public float atk;
        public float def;

    }

}
