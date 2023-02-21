using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test : MonoBehaviour
{
    public int te;
    public GameObject tmpValue;
    public string val;
    TextMeshProUGUI textValue;

    public abc script;
    // Start is called before the first frame update
    void Start()
    {
        textValue = tmpValue.GetComponent<TextMeshProUGUI>();


    }

    // Update is called once per frame
    void Update()
    {
        te = GameObject.FindGameObjectWithTag("data").GetComponent<abc>().obstacleA;
        textValue.text = te.ToString();

    }
}
