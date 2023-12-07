using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager
{
    public static Level LevelBackEnd = new Level(); //Current Level & 2D Space
    public static TileGrid LevelFrontEnd; //Contains visual objects (3D Space)
    public static Player Player = new Player();
    public static List<Enemy> enemies = new List<Enemy>();

    
    /*
    public static ChangeToNextLevel()
    {
        
    }
    */

    public static void GoToLevel(int level)
    {
        switch (level)
        {
            case 1: LevelBackEnd = PreMadeLevels.Level1; break;
            case 2: LevelBackEnd = PreMadeLevels.Level1; break;
            case 3: LevelBackEnd = PreMadeLevels.Level1; break;
            case 4: LevelBackEnd = PreMadeLevels.Level1; break;
        }
    }

    public static void MoveGhosts() 
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].Move();
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
