using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class txt : MonoBehaviour
{

    public GameObject tmpValue;
    public string val;
    TextMeshProUGUI textValue;

    public bool script1;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        textValue = tmpValue.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        textValue.text = val;
        script1 = GameObject.FindGameObjectWithTag("vid1").GetComponent<Play1>().vid1Status;
        // script2 = GameObject.FindGameObjectWithTag("vid2").GetComponent<Play2>().vid2Status;
        // script3 = GameObject.FindGameObjectWithTag("vid3").GetComponent<Play3>().vid3Status;


        // if(script1){
        //     val = "Playing Video 1";
        // }
        // else if(script2){
        //     val = "Playing Video 2";
        // }else if(script3){
        //     val = "Playing Video 3";
        // }
        if(script1){
            counter++;
        }

        if(!script1 && counter > 0){
            val = "paulsed";
        }else{
            val = "";
        }

        if(Input.GetKeyDown(KeyCode.T)){
            val = "No Video Playing";
        }  
    }
}
