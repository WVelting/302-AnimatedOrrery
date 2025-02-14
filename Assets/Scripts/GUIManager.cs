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
    public OrbitScript[] orbits;
    public PlanetaryRotation[] rotations;
    private bool isRewind = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        cam.thingToTarget = systemView;
        cam.nextPlanet = systemView;
    }

    public void OnClickSystemView(){
        if(cam.nextPlanet != systemView) {
            cam.nextPlanet = systemView;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 0, 20);
        }
        else return;
    }

    public void OnClickCoriolanus(){
        if(cam.nextPlanet != coriolanus) {
            cam.nextPlanet = coriolanus;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 30, 50);
        }
        else return;
    }

    public void OnClickOctavius(){
        if(cam.nextPlanet != octavius) {
            cam.nextPlanet = octavius;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 10, 20);
        }
        else return;
    }   

    public void OnClickCassius(){
        if(cam.nextPlanet != cassius) {
            cam.nextPlanet = cassius;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 10, 20);
        }
        else return;
    }

    public void OnClickAntonius(){
        if(cam.nextPlanet != antonius) {
            cam.nextPlanet = antonius;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 10, 20);
        }
        else return;
    }

    public void OnClickCaesar(){
        if(cam.nextPlanet != caesar) {
            cam.nextPlanet = caesar;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 15, 30);
        }
        else return;
    }

    public void OnClickCaepio(){
        if(cam.nextPlanet != caepio) {
            cam.nextPlanet = caepio;
            cam.disToTarget = Mathf.Clamp(cam.disToTarget, 5, 20);
        }
        else return;
    }

    public void OnClickPause(){
        timer.timeScale = 0;
    }

    public void OnClickPlay(){
        if(!isRewind) timer.timeScale = 1;
        if(isRewind){
            foreach(OrbitScript p in orbits){
            p.timeFlip = 1;
        }

        foreach(PlanetaryRotation r in rotations){
            r.rot*=-1;
        }
        isRewind = false;
        timer.timeScale = 1;
        }
    }

    public void OnClickFF(){
        if(isRewind) OnClickPlay();
        
        timer.timeScale = 3;
    }

    public void OnClickRewind(){
        
        if(isRewind) return;
        foreach(OrbitScript p in orbits){
            p.timeFlip = -1;
        }

        foreach(PlanetaryRotation r in rotations){
            r.rot*=-1;
        }
        isRewind = true;
        
    }

}
