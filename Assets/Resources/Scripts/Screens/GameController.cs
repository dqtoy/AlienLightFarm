﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    Library library;
    float currentVal;

    bool stopGame;
    bool startGame;
	// Use this for initialization
	void Awake () {
        library = GameObject.FindObjectOfType<Library>();
	}
	
	// Update is called once per frame
	void Update () {



        if (currentVal == GameplayConstants.MaxAgro)
            GameOver();

        //currentVal = Mathf.Max(0, currentVal - Time.deltaTime * GameplayConstants.RecoveryAgroCoef);

        //library.bgController.UpdateColor(currentVal/ GameplayConstants.MaxAgro);

        library.agroLineController.UpdateLength(currentVal/100f);

               
	}


    public void DeathAlien()
    {
        currentVal = Mathf.Min(GameplayConstants.MaxAgro, currentVal+ GameplayConstants.AgroCoef/*GetAgro()/* GameplayConstants.MaxAgro *GameplayConstants.AgroCoef/ library.aliens.GetComponent<AlienController>().GetAlienCount()*/);
    }

    /*
    float GetAgro()
    {
        int alienCount = library.aliens.GetComponent<AlienController>().GetAlienCount();

        for(int i = GameplayConstants.AgroCoef.Length -1; i >= 0; i--)
        {
            if(alienCount >= GameplayConstants.AgroCoefAlienCountTreshold[i])
            {
                return GameplayConstants.AgroCoef[i];
            }
        }

        return 100;
       // GameplayConstants.MaxAgro* GameplayConstants.AgroCoef
    }*/

    public void StartGame()
    {
        startGame = true;
        stopGame = false;
    }

    void GameOver()
    {
        //Time.timeScale = 0;
        if (!stopGame)
        {
            stopGame = true;
            library.screenController.ShowEndScreen();
        }
    }

    public void ToDefault()
    {
        currentVal = 0;
        library.agroLineController.Reset();
        library.aliens.GetComponent<AlienController>().ToDefault();
        library.map.ToDefault();
        library.uiButtonsController.ToDefault();
    }

    public void UpdateBackground()
    {
       

        library.bgController.SetBackground(PreferencesSaver.GetCurrentElementInMarket());
    }


}
