using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
// using UnityEngine.Debug;

public class abc : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM4", 9600);
    public string receivedstring;
    public string data;
    public string data_received;

    public int obstacleA;


    void Start()
    {
        stream.Open();
        obstacleA = 0;
        print("started");

    }

    void Update()
    {

        // reading values from the arduino input using stream


    try
    {
        if (stream.IsOpen && stream.BytesToRead > 0)
        {
            data_received = stream.ReadTo("\n"); 
            print("Arduino: " + data_received);
            if(!string.IsNullOrEmpty(data_received)){
                int.TryParse(data_received, out obstacleA);
                print("A: " + obstacleA);
            }

        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadSceneAsync(
            SceneManager.GetActiveScene().buildIndex);
    }
    }
    catch (IOException ex)
    {
        print("Error reading from the serial port: " + ex.Message);
    }
    }


}

