﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class RayCastHandler : MonoBehaviour
{
    public float firstDistance = 10,secondDistance =5,thirdDistance = 3;
    // Update is called once per frame

    //Middle point 
    public GameObject Middle;
    public GameObject DroneGameObject;

    public float Radius = 100;

    public TextMeshPro frontDistance, backDistance, leftDistance, rightDistance,frontleftDistance,frontrightDistance,backleftDistance,backrightDistance;
    public TextMeshProUGUI topDistance,bottomDistance;

    public GameObject front,back,left,right,frontright,frontleft,backright,backleft,top,bottom;
    public GameObject front1,back1,left1,right1,frontright1,frontleft1,backright1,backleft1,top1,bottom1;
    public GameObject front2,back2,left2,right2,frontright2,frontleft2,backright2,backleft2,top2,bottom2;

    private enum sites{
        left,frontleft,front,frontright,right,backright,back,backleft,top,bottom
    }
    void Start()
    {
        frontDistance.text = "";
        backDistance.text = "";
        leftDistance.text = "";
        rightDistance.text = "";
        frontleftDistance.text = "";
        frontrightDistance.text = "";
        backleftDistance.text = "";
        backrightDistance.text = "";
    }

    void ManageRays(Vector3 SideVector,  sites site){
        RaycastHit hit;
        Ray ray = new Ray(DroneGameObject.transform.position, SideVector);
        float mindistance = 1000;
        if(Physics.SphereCast(ray,0.01f, out hit)){
            if(hit.transform.gameObject.layer == 8 || hit.transform.gameObject.layer == 10 || hit.transform.gameObject.layer == 14)
                mindistance = hit.distance;
        }  

        switch(site){
            case sites.back:
                backDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    back.SetActive(false);
                    backDistance.gameObject.SetActive(false);
                }
                else{
                    back.SetActive(true);
                    backDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    back1.SetActive(true);
                    else
                    back1.SetActive(false);

                if(mindistance < thirdDistance)
                    back2.SetActive(true);
                    else
                    back2.SetActive(false);


                break;
            case sites.backleft:
                backleftDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    backleft.SetActive(false);
                    backleftDistance.gameObject.SetActive(false);
                }
                else{
                    backleft.SetActive(true);
                    backleftDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    backleft1.SetActive(true);
                    else
                    backleft1.SetActive(false);

                if(mindistance < thirdDistance)
                    backleft2.SetActive(true);
                    else
                    backleft2.SetActive(false);
                break;
            case sites.backright:
               backrightDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    backright.SetActive(false);
                    backrightDistance.gameObject.SetActive(false);
                }
                else{
                    backright.SetActive(true);
                    backrightDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    backright1.SetActive(true);
                    else
                    backright1.SetActive(false);

                if(mindistance < thirdDistance)
                    backright2.SetActive(true);
                    else
                    backright2.SetActive(false);
                break;
            case sites.front:
                frontDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    front.SetActive(false);
                    frontDistance.gameObject.SetActive(false);
                }
                else{
                    front.SetActive(true);
                    frontDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    front1.SetActive(true);
                    else
                    front1.SetActive(false);

                if(mindistance < thirdDistance)
                    front2.SetActive(true);
                    else
                    front2.SetActive(false);
                break;
            case sites.frontleft:
                frontleftDistance.text =(Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    frontleft.SetActive(false);
                    frontleftDistance.gameObject.SetActive(false);
                }
                else{
                    frontleft.SetActive(true);
                    frontleftDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    frontleft1.SetActive(true);
                    else
                    frontleft1.SetActive(false);

                if(mindistance < thirdDistance)
                    frontleft2.SetActive(true);
                    else
                    frontleft2.SetActive(false);
                break;
            case sites.frontright:
                frontrightDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    frontright.SetActive(false);
                    frontrightDistance.gameObject.SetActive(false);
                }
                else{
                    frontright.SetActive(true);
                    frontrightDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    frontright1.SetActive(true);
                    else
                    frontright1.SetActive(false);

                if(mindistance < thirdDistance)
                    frontright2.SetActive(true);
                    else
                    frontright2.SetActive(false);
                break;
            case sites.left:
                leftDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    left.SetActive(false);
                    leftDistance.gameObject.SetActive(false);
                }
                else{
                    left.SetActive(true);
                    leftDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    left1.SetActive(true);
                    else
                    left1.SetActive(false);

                if(mindistance < thirdDistance)
                    left2.SetActive(true);
                    else
                    left2.SetActive(false);
                break;
            case sites.right:
                rightDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    right.SetActive(false);
                    rightDistance.gameObject.SetActive(false);
                }
                else{
                    right.SetActive(true);
                    rightDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    right1.SetActive(true);
                    else
                    right1.SetActive(false);

                if(mindistance < thirdDistance)
                    right2.SetActive(true);
                    else
                    right2.SetActive(false);
                break;
            case sites.top:
               topDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    top.SetActive(false);
                    topDistance.gameObject.SetActive(false);
                }
                else{
                    top.SetActive(true);
                    topDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    top1.SetActive(true);
                    else
                    top1.SetActive(false);

                if(mindistance < thirdDistance)
                    top2.SetActive(true);
                    else
                    top2.SetActive(false);
                break;
            case sites.bottom:
               bottomDistance.text = (Math.Round(mindistance, 2)).ToString();
                if(mindistance > firstDistance){
                    bottom.SetActive(false);
                    bottomDistance.gameObject.SetActive(false);
                }
                else{
                    bottom.SetActive(true);
                    bottomDistance.gameObject.SetActive(true);
                }

                if(mindistance < secondDistance)
                    bottom1.SetActive(true);
                    else
                    bottom1.SetActive(false);

                if(mindistance < thirdDistance)
                    bottom2.SetActive(true);
                    else
                    bottom2.SetActive(false);
                break;
        }
    }

    void Update()
    {
        // Left
        ManageRays(-transform.right, sites.left);

        // Right
        ManageRays(transform.right, sites.right);
        
        
        // Right Upper
        ManageRays(transform.right+transform.forward,sites.frontright);

        // Left Lower
        ManageRays(-(transform.right+transform.forward),sites.backleft);

        // Left Upper
        ManageRays( transform.forward-transform.right,sites.frontleft);

        // Right Lower
        ManageRays(-transform.forward+transform.right,sites.backright);
        
        // Up
        ManageRays(transform.forward,sites.front);

        // Down
        ManageRays(-transform.forward,sites.back);

        ManageRays(transform.up, sites.top);

        ManageRays(-transform.up, sites.bottom);
        
    }
}
