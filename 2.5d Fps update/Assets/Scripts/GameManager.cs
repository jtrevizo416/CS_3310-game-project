﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public bool isPauseMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        LockCursor();
    }

    // Update is called once per frame
    void Update()
    {
        

       // if (Input.GetKeyDown(KeyCode.P))//if user presses p key unlock the cursor
       // {
       //     UnlockCursor();
       // }

       //if (Input.GetKeyDown(KeyCode.K))//if user presses p key lock the cursor
       // {
       //     LockCursor();
       //}

      //if (PlayerController.instance.currentHealth <= 0)//if player dies unlock cursor to be able to restart
      //{
      //      UnlockCursor();
      //}

       // if (Input.GetKey(KeyCode.P))
       // {
       //     isPauseMenu = true;
       // }

       // if (isPauseMenu == true)
       // {
       //     UnlockCursor();
       // }

       // //if (isPauseMenu == false)
       //// {
       //     LockCursor();
       // }
        
    }

    private void LockCursor()//Lock cursor to window and make it dissapear when playing the game
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
