using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static Level LevelBackEnd = new Level(); //Current Level & 2D Space
    public static TileGrid LevelFrontEnd; //Contains visual objects (3D Space)
    public static Player Player = new Player();


    public static void SwapLevel(int level)
    {
        switch (level)
        {
            case 1: LevelBackEnd = PreMadeLevels.Level1; break;
        }

        
    }

    public static void inputDirector(){
        switch (GameplayLoop.associatedKey) {
            case "UP" or "DOWN" or "LEFT" or "RIGHT":
                Player.movePlayer(); 
                break;
      
            //case "INTERACT":{run input objects}
            //case "Swap Tabs"  
        }
    
    }
}
