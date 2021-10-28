using Unity.Netcode;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : NetworkBehaviour
{
    public float health = 10f;
    public void HandleMovement()
    {
        if (IsLocalPlayer)
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
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.layer == 7)
        // {
            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
            Destroy(other.gameObject);
            health ++;
        // }
        // if (other.gameObject.layer == 8)
        // {
        //     GetComponent<Renderer>().material.color = Color.blue;
        //     Destroy(other.gameObject);
        //     health ++;
        // }
        // if (other.gameObject.layer == 9)
        // {
        //     GetComponent<Renderer>().material.color = Color.yellow;
        //     Destroy(other.gameObject);
        //     health ++;
        // }
    }
}