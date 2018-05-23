using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    public Perfect Perfect;
    public Good Good;
    public Bad Bad;

    public Text scoreText;
    public static int score = 0;
    public static int psum = 0;
    public static int gsum = 0;
    public static int bsum = 0;

    public static int getscore()
    {
        return score;
    }

    public static int getpsum()
    {
        return psum;
    }

    public static int getgsum()
    {
        return gsum;
    }

    public static int getbsum()
    {
        return bsum;
    }

    // Use this for initialization
    void Start()
    {
        scoreText.text = "Score: 0";
    }
	
	// Update is called once per frame
	void Update () {

        int score1;
        score1 = Perfect.Score1;

        int score2;
        score2 = Good.Score2;

        score = score1 + score2;
        scoreText.text = "Score: " + score.ToString();

        psum = Perfect.Pcnt;

        gsum = Good.Gcnt;

        bsum = Bad.Bcnt;
    }
}
