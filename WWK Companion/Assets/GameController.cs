using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public List<GameObject> SetupInstructions;
    public List<GameObject> GameRules;

    public GameObject MainScreen;

    public GameObject CoinsScreen;
    public GameObject WizardScreen;
    public GameObject CardScreen;
    public GameObject TileScreen;

    public GameObject SetupScreen;

    AudioSource audioSource;
    public AudioClip audioClip;

    int currSetup;
    int currRule;
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

    public void NextSetupStep()
    {        
        

        if(currSetup >= SetupInstructions.Count)
        {
            currSetup = 0;
            
        }

        ClearScreen();
        SetupInstructions[currSetup].SetActive(true);

        currSetup++;

    }

    void ClearScreen()
    {
        foreach(GameObject obj in SetupInstructions)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in GameRules)
        {
            obj.SetActive(false);
        }
        CoinsScreen.SetActive(false);
        WizardScreen.SetActive(false);
        CardScreen.SetActive(false);
        TileScreen.SetActive(false);
    }



    void ShowMainScreen()
    {
        SetupScreen.SetActive(false);
       
        MainScreen.SetActive(true);
    }
}
