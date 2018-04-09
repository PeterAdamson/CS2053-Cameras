using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
   public enum GameState {BEGIN, PLAYING, WIN, LOSE};

   public static GameState gameState = GameController.GameState.BEGIN;

   public Text title;
   public Text finishText;
   private int numOfCPU;

   void Start()
   {
       finishText.text = "";
       numOfCPU = 3;
       title = GameObject.Find("Title").GetComponent<Text>();
       if (title != null) {
           if (gameState == GameController.GameState.BEGIN)
               title.text = "Ball Escape!!";
           else if (gameState == GameController.GameState.WIN)
               title.text = "You Win!";
           else if (gameState == GameController.GameState.LOSE)
               title.text = "You Lose!";
       }
   }

   public void LoadGame()
   {
       gameState = GameController.GameState.PLAYING;
       SceneManager.UnloadSceneAsync("MainMenu");
       SceneManager.LoadScene("Game");
   }

   public void QuitGame()
   {
       Application.Quit();
   }

   public void incr()
   {
     numOfCPU = numOfCPU - 1;
     if(numOfCPU <= 0)
     {
       finishText.text = "You Win!";
       Time.timeScale = 0;
     }
   }

   public void gameOver()
   {
     finishText.text = "You Lose!";
     Time.timeScale = 0;
   }
}
