using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera MainCamera;

    public BoxCollider2D TopWall;
    public BoxCollider2D BottomWall;
    public BoxCollider2D LeftWall;
    public BoxCollider2D RightWall;

    public Transform Player01;
    public Transform Player02;

    void Update()
    {
        TopWall.size = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        TopWall.offset = new Vector2(0f, MainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        BottomWall.size = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        BottomWall.offset = new Vector2(0f, MainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        LeftWall.size = new Vector2(1f, MainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        LeftWall.offset = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        RightWall.size = new Vector2(1f, MainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        RightWall.offset = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        Player01.position = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, Player01.position.y);
        Player02.position = new Vector2(MainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, Player02.position.y);
    }
}

