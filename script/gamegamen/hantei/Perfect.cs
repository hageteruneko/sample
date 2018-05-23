using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perfect : MonoBehaviour
{
    private int score1 = 0;
    private int pcnt = 0;

    public int Score1
    {
        get { return this.score1; }
        private set { this.score1 = value; }
    }
    public int Pcnt
    {
        get { return this.pcnt; }
        private set { this.pcnt = value; }
    }

    void Start()
    {
     
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Notes"))
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.J))
            {
                Destroy(other.gameObject);
                Debug.Log("Perfect");
                pcnt++;
                score1 += 1000;
            }
        }
        if (other.gameObject.CompareTag("Notess"))
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.K))
            {
                Destroy(other.gameObject);
                Debug.Log("Perfect");
                pcnt++;
                score1 += 1000;
            }
        }
    }
}
