using UnityEngine;
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

    AudioSource audioSource;
    public AudioClip audioClip;

    int currSetup;
    int currTute;
    GameObject currScreen;


	// Use this for initialization
	void Start () {
        audioSource = FindObjectOfType<AudioSource>();
        ClearScreen();

        currSetup = 0;

        PlayBtnPressed();

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
    public void PlayBtnPressed()
    {
        audioSource.PlayOneShot(audioClip);
    }
    public void StopBtnPressed()
    {
        audioSource.Pause();
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
		TutorialSteps[currTute].SetActive(true);

		currTute++;

	}
    public void NextSetupStep()
    {        
        

        if(currSetup >= SetupInstructions.Count)
        {
            currSetup = 0;

            
        }


        ClearScreen();
        SetupScreen.SetActive(true);
        SetupInstructions[currSetup].SetActive(true);

        currSetup++;

    }
    public void Rules_BtnPressed()
    {
        ClearScreen();

        ChangeObjectStates(MainMenuButtons, false);
        ChangeObjectStates(RulesMenuButtons, true);

        //MainScreen.SetActive(false);
        //RulesMenu.SetActive(true);


    }

    void ClearScreen()
    {

        ChangeObjectStates(SetupInstructions, false);

        ChangeObjectStates(TutorialSteps, false);

        CoinsScreen.SetActive(false);
        WizardScreen.SetActive(false);
        CardScreen.SetActive(false);
        TileScreen.SetActive(false);
        //MainScreen.SetActive(false);
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
        SetupScreen.SetActive(false);

        ChangeObjectStates(MainMenuButtons, true);
        ChangeObjectStates(RulesMenuButtons, false);
    }
}
