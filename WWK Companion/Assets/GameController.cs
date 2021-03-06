﻿using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public List<GameObject> SetupInstructions;
    public List<GameObject> TutorialSteps;

    public List<GameObject> MainMenuButtons;
    public List<GameObject> RulesMenuButtons;

    public GameObject CoinsScreen;
    public GameObject WizardScreen;
    public GameObject CardScreen;
    public GameObject TileScreen;

    public GameObject SetupScreen;
    public GameObject TuteScreen;

    public GameObject Logo;

    int currSetup;
    int currTute;
    


	// Use this for initialization
	void Start () {

        //ClearScreen();

        currSetup = 0;
        currTute = 0;

        //PlayBtnPressed();

        ShowMainScreen();

    }
	
	// Update is called once per frame
	void Update () {

	
	}

    public void CoinsBtnPressed()
    {
        ClearScreen();
        CoinsScreen.SetActive(true);
    }
    public void CardsBtnPressed()
    {
        ClearScreen();
        CardScreen.SetActive(true);
    }
    public void WizardsBtnPressed()
    {
        ClearScreen();
        WizardScreen.SetActive(true);
    }
    public void TilesBtnPressed()
    {
        ClearScreen();
        TileScreen.SetActive(true);
    }
    public void TuteBtnPressed()
    {
		NextTutorialStep ();
    }
    public void SetupBtnPressed()
    {
        //currSetup = 0;
        NextSetupStep();
    }
	public void NextTutorialStep()
	{        


		if(currTute >= TutorialSteps.Count)
		{
			currTute = 0;

		}


		ClearScreen();
        TuteScreen.SetActive(true);
        TutorialSteps[currTute].SetActive(true);

		currTute++;

	}
    public void PrevTutorialStep()
    {


        currTute--;

        if (currTute < 0)
        {
            currTute = TutorialSteps.Count;
        }


        ClearScreen();
        TuteScreen.SetActive(true);
        TutorialSteps[currTute].SetActive(true);

    }
    public void NextSetupStep()
    {
        

        if (currSetup >= SetupInstructions.Count)
        {
            currSetup = 0;

            
        }


        ClearScreen();
        SetupScreen.SetActive(true);
        SetupInstructions[currSetup].SetActive(true);


        currSetup++;
    }
    public void PrevSetupStep()
    {

        currSetup--;

        if (currSetup < 0)
        {
            currSetup = SetupInstructions.Count;
        }


        ClearScreen();
        SetupScreen.SetActive(true);
        SetupInstructions[currSetup].SetActive(true);

        

    }
    public void Rules_BtnPressed()
    {
        ClearScreen();

        ChangeObjectStates(MainMenuButtons, false);
        ChangeObjectStates(RulesMenuButtons, true);

        ShowLogo();
    }
    public void MainMenuBtnPressed()
    {
        ClearScreen();

        ChangeObjectStates(MainMenuButtons, true);
        ChangeObjectStates(RulesMenuButtons, false);

        ShowLogo();
    }

    void ShowLogo()
    {
        ClearScreen();
        Logo.SetActive(true);
    }

    void ClearScreen()
    {

        ChangeObjectStates(SetupInstructions, false);

        ChangeObjectStates(TutorialSteps, false);
        Logo.SetActive(false);
        CoinsScreen.SetActive(false);
        WizardScreen.SetActive(false);
        CardScreen.SetActive(false);
        TileScreen.SetActive(false);
        TuteScreen.SetActive(false);
        SetupScreen.SetActive(false); 
    }

    void ChangeObjectStates(List<GameObject> _list, bool state)
    {
        foreach (GameObject obj in _list)
        {
            obj.SetActive(state);
        }

        print("changed states");
    }

    void ShowMainScreen()
    {
        ClearScreen();

        SetupScreen.SetActive(false);
        ShowLogo();

        ChangeObjectStates(MainMenuButtons, true);
        ChangeObjectStates(RulesMenuButtons, false);
    }
}
