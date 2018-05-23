//NodeCreater

using UnityEngine;
using System.Collections.Generic;

public class NodeCreater2 : MonoBehaviour
{
    private CSVReader csvReader = new CSVReader();
    private List<List<string>> MAP = new List<List<string>>();
    private float time;
    public GameObject Node;
    private GameObject nodeParent;
    private GameObject lostPosition;
    private GameObject destination;
    private GameObject ScoreText;
    private int Line = 0;
    public int Selector = 0;

    private void Awake()
    {
        nodeParent = gameObject.transform.parent.gameObject;
        destination = GameObject.Find(nodeParent.name + "/TapPosition");
        lostPosition = GameObject.Find(nodeParent.name + "/LostPosition");
        ScoreText = GameObject.Find("NotesLine1/Canvas/Score");
        Selector = int.Parse(nodeParent.name.Replace("NotesLine", ""));
        MAP = csvReader.readCSV("TestTiming");
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= float.Parse(MAP[Line][0]))
        {
            if ((int.Parse(MAP[Line][Selector]) == 0))
            {
                NodeCreate();
            }
            Line++;
        }
    }

    private void NodeCreate()
    {
        var node = (GameObject)Instantiate(Node, nodeParent.transform);
        node.GetComponent<NodeMove>().destination = destination;
        node.GetComponent<NodeMove>().lostPosition = lostPosition;
        node.transform.localPosition = transform.localPosition;
        node.transform.localRotation = transform.localRotation;
        node.transform.localScale = new Vector3(0.01000000001f, 0.5f, 0.5f);
    }
}
