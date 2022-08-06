using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCanvas : MonoBehaviour
{
    Gamemanager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = FindObjectOfType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            gamemanager.StartGame();
        }
    }
}
