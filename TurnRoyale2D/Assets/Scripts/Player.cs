using Unity.Netcode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : NetworkBehaviour
{
    public bool isLocalPlayer;
    public void HandleMovement()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(new Vector2(1f,0f));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector2(-1f,0f));
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(new Vector2(0f,1f));
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(new Vector2(0f,-1f));
            }
        }
    }
    void Update()
    {
            HandleMovement();
    }
}