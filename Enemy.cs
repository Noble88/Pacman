/*
 * Rylen Sakamoto
 * 2371074
 * rsakamoto@chapman.edu
 * CPSC245-2
 * Final Project
 * Enemy: Chases player and destroys when occupying the same space.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy //Should be EnemyBase?
{
    public Vector2Int position = new Vector2Int(1, 1);
    public char enemySymbol = 'E';
    public ArrayList walkablesList = new ArrayList { ',', '|' };
    
    private int horizontalDistance;
    private int verticalDistance;
    private string horizontalSignal;
    private string verticalSignal;
    public string preference; //HORIZONTAL or VERTICAL
    public char sym;

    private enum States
    {
        Normal,
        Killable
    }

    public Enemy(string preference, Vector2Int spawn, char enemySymbol)
    {
        this.preference = preference;
        sym = enemySymbol;
        SpawnEnemies(spawn);
    }

    public void SpawnEnemies(Vector2Int destination)
    {
        position = destination; //Resigned enemy position
        LevelManager.LevelBackEnd.setE(position, sym, true); //Add enemies (w/Updated Position)
    }

    void Update()
    {
        /*
        playerPosition = Player.pos;
        if (enemyPosition == playerPosition)
            KillPlayer();
        else
        {
            Move(playerPosition);
        }
        */

        //If Reverse Pellet is activated
        //Become Killable (STATES/TIMER)
        //When Reverse Pellet is deactivated
        //Become Normal
    }

    public void Move(Vector2 playerPosition)
    {
        Vector2Int destination = new Vector2Int(0, 0);
        //Check closest between horizontal/vertical ints (USE UNITY FORMAT, CHECK GLOBALMETHODS)
        horizontalSignal= HorizontalCheck();
        verticalSignal = VerticalCheck();

        GlobalMethods.moveCharOnLevel(position,findDestination(),sym);

    }


    public bool setDestination;
    Vector2Int findDestination() {
        if (IsPlayerInLineOfSight()) { //if ghost is directly on the same line as player & no wall
            if(horizontalSignal.Equals("NONE")){
                return GlobalMethods.findCords(position,verticalSignal);
            }
            if(verticalSignal.Equals("NONE")){//if 
                return GlobalMethods.findCords(position,horizontalSignal);
            }
        }
        
        
        if (horizontalSignal.Equals("NONE"))//if ghost and player are on the same x value & if wall
        {
            return new Vector2Int(0,0);
        }

        if (verticalDistance.Equals("NONE"))// if some y value & if wall
        {
            return GlobalMethods.findCords(position,closestVerticalLane());
        }
        else
        {
            if(preference.Equals("HORIZONTAL")){ return GlobalMethods.findCords(position,horizontalSignal); }
            if(preference.Equals("VERTICAL")){ return GlobalMethods.findCords(position,verticalSignal); }

            Vector2Int horizontalDestination = GlobalMethods.findCords(position,horizontalSignal);
            Vector2Int verticalDestination = GlobalMethods.findCords(position,verticalSignal);

            if (LevelManager.LevelBackEnd.getE(horizontalDestination,true) == ' ' && //Hitting a wall
                horizontalSignal.Equals("NONE")&& //Same horiz at player
                preference.Equals("HORIZONTAL")) //Always wants to go horizontal)
            {
                
            }

            LevelManager.LevelBackEnd.getE(verticalDestination,true);
        }

    }
    public bool IsPlayerInLineOfSight()
    {
        
    }
    
    public string closestVerticalLane()
    {
        int leftPos = -40;
        int rightPos = -30;
        for (int leftside = position.x; leftside>-1; leftside--)
        {
            char symbol = LevelManager.LevelBackEnd.getE(GlobalMethods.findCords(
                new Vector2Int(GlobalMethods.findCords(position,horizontalSignal).y,leftside),"LEFT"),true);
            if (symbol != ' ') { leftPos = leftside; Debug.Log("leftside "+leftPos); break; }
        }
        for (int rightside = position.x; rightside>21; rightside--)
        {
            char symbol = LevelManager.LevelBackEnd.getE(GlobalMethods.findCords(
                new Vector2Int(GlobalMethods.findCords(position,horizontalSignal).y,rightside),"RIGHT"),true);
            if (symbol != ' ') { rightPos = rightside; Debug.Log("rightSide "+rightPos);break; }
        }

        if (leftPos<rightPos) { return "LEFT"; }
        if(rightPos<leftPos){ return  "RIGHT";}
        if (rightPos == leftPos && LevelManager.Player.directionFacing.Equals("LEFT")) { return "LEFT"; }
        if (rightPos == leftPos && LevelManager.Player.directionFacing.Equals("RIGHT")) { return  "RIGHT"; }
        else {Debug.Log("SOMETHINB BIG WRONG CLOESEST VERT LANE"); return "N/A";}
    }

    string HorizontalCheck()
    {
        //USE TILE FORMAT
        horizontalDistance = LevelManager.Player.pos.x - position.x;
        if (horizontalDistance < 0) { return "LEFT"; }
        else if (horizontalDistance > 0) { return "RIGHT"; }
        else if (horizontalDistance == 0) { return "NONE"; }
        return "MAJOR PROBLEM";
    }

    string VerticalCheck()
    {
        //USE TILE FORMAT
        verticalDistance = LevelManager.Player.pos.y - position.y;
        if (verticalDistance < 0) { return "UP"; }
        else if (verticalDistance > 0) { return "DOWN"; }
        else if (verticalDistance == 0) { return "NONE"; }
        return "MAJOR PROBLEM";
    }

    void KillPlayer()
    {
        //(TILE BASED)
        //Send notification to kill player.
    }
}
