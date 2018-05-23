using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour {
    public Text scoreText;
    public Text PerfectText;
    public Text GoodText;
    public Text BadText;
    // Use this for initialization
    void Start () {
        int resultscore = ScoreCounter.getscore();
        int resultPerfect = ScoreCounter.getpsum();
        int resultGood = ScoreCounter.getgsum();
        int resultBad = ScoreCounter.getbsum();

        scoreText.text = "Score: " + resultscore.ToString(); ;
        PerfectText.text = "Perfect: " + resultPerfect.ToString(); ;
        GoodText.text = "Good: "+ resultGood.ToString();
        BadText.text = "Bad: " + resultBad.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
