using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Play2 : MonoBehaviour
{
    // Boolean to check if the video is playing
    public bool vid2Status;
    private VideoPlayer vid2;

    public int infrared2Status1;
    public int infrared2Status2;
    public int infrared2Status3;
    void Start()
    {
        // Initialize the video player
        // Turn playOnAwake off
        vid2 = GetComponent<VideoPlayer>();
        vid2.playOnAwake = false;
        vid2Status = false;

    }

    void Update()
    {
        vid2.enabled = true;
        infrared2Status1 = GameObject.FindGameObjectWithTag("data").GetComponent<abc>().obstacleA;
        // infrared2Status2 = GameObject.FindGameObjectWithTag("data").GetComponent<abc>().obstacleB;
        // infrared2Status3 = GameObject.FindGameObjectWithTag("data").GetComponent<abc>().obstacleC;

        if(infrared2Status2 == 0){
            vid2.Play();
            vid2Status = true;
        }else if(infrared2Status1 == 0 || infrared2Status3 == 0){
            vid2.enabled = false;
            vid2Status = false;
        }










        // Play video when 'S' is pressed
        // Pause video when 'Space' or 'S' is pressed again
        // Turn off video when any of the other video starts playing (When 'A' or 'D' is pressed)

        // if(Input.GetKeyDown(KeyCode.S) && vid2Status == false){
        //     vid2.Play();
        //     vid2Status = true;
        // }else if((Input.GetKeyDown(KeyCode.Space) && vid2Status == true) || (Input.GetKeyDown(KeyCode.S) && vid2Status == true)){
        //     vid2.Pause();
        //     vid2Status = false;
            
        // }else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)){
        //     vid2.enabled = false;
        //     vid2Status = false;
        // }

        // if(Input.GetKeyDown(KeyCode.T)){
        //     vid2.enabled = false;        
        //     vid2Status = false;

        // }
    }
}
