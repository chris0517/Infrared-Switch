using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public GameObject tmpValue;
    public string val;
    TextMeshProUGUI textValue;

    public bool script1;
    public bool script2;
    public bool script3;

    void Start()
    {
        val = "No Video Playing";
        textValue = tmpValue.GetComponent<TextMeshProUGUI>();
    }



    void Update()
    {
        textValue.text = val;
        script1 = GameObject.FindGameObjectWithTag("vid1").GetComponent<Play1>().vid1Status;
        script2 = GameObject.FindGameObjectWithTag("vid2").GetComponent<Play2>().vid2Status;
        script3 = GameObject.FindGameObjectWithTag("vid3").GetComponent<Play3>().vid3Status;


        if(script1){
            val = "Playing Video 1";
        }else if(script2){
            val = "Playing Video 2";
        }else if(script3){
            val = "Playing Video 3";
        }

        if(Input.GetKeyDown(KeyCode.T)){
            val = "No Video Playing";
        }
    }
}
