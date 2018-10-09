using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{

    public Transform WallTransform;
    private AudioSource audioSource;

    void Start ()
	{
	    WallTransform = GetComponent<Transform>();
	    audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Ball")
        {
            var wallName = WallTransform.name;
            GameManager.Score(wallName);
            audioSource.Play(0);
            collider.gameObject.SendMessage("ResetBall");
        }
    }
}
