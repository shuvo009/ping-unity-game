using System.Collections;
using System.Collections.Generic;
using Boo.Lang;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int PlayerScore01 = 0;
    public static int PlayerScore02 = 0;
    public GUISkin skin;
    private Transform theBall;
    public static void Score(string wallName)
    {
        if (wallName == "rightWall")
        {
            PlayerScore01 += 1;
        }
        else
        {
            PlayerScore02 += 1;
        }
    }


    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), PlayerScore01.ToString());
        GUI.Label(new Rect(Screen.width / 2 + 150 - 12, 20, 100, 100), PlayerScore02.ToString());

        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 35, 121, 53), "Reset"))
        {
            PlayerScore01 = 0;
            PlayerScore02 = 0;
            theBall.gameObject.SendMessage("ResetBall");
        }
    }
}
