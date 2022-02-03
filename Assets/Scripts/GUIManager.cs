using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{

    public CameraRig cam;
    public TimeManager timer;
    public Transform systemView;
    public Transform coriolanus;
    public Transform octavius;
    public Transform cassius;
    public Transform antonius;
    public Transform caesar;
    public Transform caepio;
    void Start()
    {
        cam.thingToTarget = systemView;
        cam.nextPlanet = systemView;
    }

    public void OnClickSystemView(){
        if(cam.nextPlanet != systemView) cam.nextPlanet = systemView;
        else return;
    }

    public void OnClickCoriolanus(){
        if(cam.nextPlanet != coriolanus) cam.nextPlanet = coriolanus;
        else return;
    }

    public void OnClickOctavius(){
        if(cam.nextPlanet != octavius) cam.nextPlanet = octavius;
        else return;
    }   

    public void OnClickCassius(){
        if(cam.nextPlanet != cassius) cam.nextPlanet = cassius;
        else return;
    }

    public void OnClickAntonius(){
        if(cam.nextPlanet != antonius) cam.nextPlanet = antonius;
        else return;
    }

    public void OnClickCaesar(){
        if(cam.nextPlanet != caesar) cam.nextPlanet = caesar;
        else return;
    }

    public void OnClickCaepio(){
        if(cam.nextPlanet != caepio) cam.nextPlanet = caepio;
        else return;
    }

    public void OnClickPause(){
        timer.timeScale = 0;
    }

    public void OnClickPlay(){
        timer.timeScale = 1;
    }

    public void OnClickFF(){
        timer.timeScale = 3;
    }

    public void OnClickRewind(){
        timer.timeScale = -1;
    }

}
