using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    List<Rule> ruleList;
    bool audioPlay;

    AudioSource audio;
    public List<AudioClip> audioClips;

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
        audioPlay = true;
    }

    public void StopBtnPressed()
    {
        audioPlay = true;
    }
}
