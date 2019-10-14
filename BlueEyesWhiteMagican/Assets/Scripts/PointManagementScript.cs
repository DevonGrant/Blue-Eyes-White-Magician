﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManagementScript : MonoBehaviour
{
    //the number of starting points, defaults to 100
    [SerializeField]
    private int points =100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// shows how many points the player has to the player
    /// </summary>
    private void OnGUI()
    {
        //draws the number of points to the screen
        GUI.backgroundColor = Color.gray;
        GUI.contentColor = Color.yellow;
        GUI.Box(new Rect(10f, 70f, 150f, 25f), output());
    }
    private string output()
    {
        return "Points: " + points.ToString();
    }

    /// <summary>
    /// adds the number of points given to the total
    /// </summary>
    /// <param name="increase">the integern number of points to add</param>
    public void addPoints(int increase)
    {
        points += increase;
    }

    /// <summary>
    /// removes points from the point manager if it has enough points
    /// </summary>
    /// <param name="Cost">the amount of points you would like to remove</param>
    /// <returns>if there are enouh points to remove</returns>
    public bool removePoints(int Cost)
    {
        if(Cost > points)
        {
            return false;
        }
        else
        {
            points -= Cost;
            return true;
        }
    }

}