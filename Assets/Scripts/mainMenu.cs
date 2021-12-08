using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gameOver(){
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(3);
        }
        
    }

    public void next(){
        SceneManager.LoadScene(6);
    }
}
