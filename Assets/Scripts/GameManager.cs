using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


 



    

    public static GameManager Instance {get; private set;}
    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed {get; private set;}
    private void Awake() {
    if (Instance == null) {
        Instance = this;
    } else {
        DestroyImmediate(gameObject);
    }
  }

private void onDestroy() {
    if (Instance == this) {
        Instance = null;
    }
  }
  private void Start() {

 
    NewGame();
  }

   public void NewGame() {
    
    gameSpeed = initialGameSpeed;
    
  
   }

   private void Update() {
    

    gameSpeed += gameSpeedIncrease * Time.deltaTime;
    
 




   }

  

    
   


  }





