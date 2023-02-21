using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Video;
//using UnityEngine.Debug;

public class abc : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM4", 9600);
    public string receivedstring;
    public string[] data;
    public string[] data_received;

    public int obstacleA;
    public int obstacleB;
    public int obstacleC;


    void Start()
    {
        stream.Open();

        // obstacleA = 0;
        // obstacleB = 0;      
        // obstacleC = 0;

        // receivedstring = stream.ReadLine();
        // stream.BaseStream.Flush();
        // print(receivedstring);

        // receivedstring = stream.ReadLine();
        // stream.BaseStream.Flush();
        // string[] data = receivedstring.Split(',');
        // print(receivedstring);


        // //data_received[0] = data[0];
        // int.TryParse(data[0], out obstacleA);

        // //data_received[1] = data[1];
        // int.TryParse(data[1], out obstacleB);

        // //data_received[2] = data[2];
        // int.TryParse(data[2], out obstacleC);

        // print("A:" + obstacleA + " B:" + obstacleB + " C:" + obstacleC);

        // data = null;

        // stream.ReadTimeout = 1000;

        // receivedstring = stream.ReadLine();
        // stream.BaseStream.Flush();
        // data = receivedstring.Split(',');
        // print(receivedstring);
    }

    void Update()
    {

        // reading values from the arduino input using stream


        receivedstring = stream.ReadLine();
        stream.BaseStream.Flush();
        string[] data = receivedstring.Split(',');

        //data_received[0] = data[0];
        int.TryParse(data[0], out obstacleA);

        //data_received[1] = data[1];
        int.TryParse(data[1], out obstacleB);

        //data_received[2] = data[2];
        int.TryParse(data[2], out obstacleC);

        print("A:" + obstacleA + " B:" + obstacleB + " C:" + obstacleC);



    }


}

