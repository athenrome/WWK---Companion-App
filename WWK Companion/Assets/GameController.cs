using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    List<Rule> ruleList;

    AudioSource audio;
    public AudioClip audioClip;

    void Awake()
    {
        audio = FindObjectOfType<AudioSource>();
    }

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

    public void RulesBtnPressed()
    {

    }

    public void SetupBtnPressed()
    {

    }

    public void ViewerBtnPressed()
    {

    }

    public void PlayBtnPressed()
    {
        audio.PlayOneShot(audioClip);
    }

    public void StopBtnPressed()
    {
        audio.Pause();
    }
}
