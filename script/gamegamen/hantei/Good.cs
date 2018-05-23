using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good : MonoBehaviour
{
    private int gcnt = 0;
    private int score2 = 0;

    public int Score2
    {
        get { return this.score2; }
        private set { this.score2 = value; }
    }
    public int Gcnt
    {
        get { return this.gcnt; }
        private set { this.gcnt = value; }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Notes"))
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.J))
            {
                Destroy(other.gameObject);
                Debug.Log("Good");
                gcnt++;
                score2 += 400;
            }
        }
        if (other.gameObject.CompareTag("Notess"))
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.K))
            {
                Destroy(other.gameObject);
                Debug.Log("Perfect");
                gcnt++;
                score2 += 400;
            }
        }
    }
}