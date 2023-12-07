using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
  public Vector2Int pos; //pos = "Player Position" or just "Position"
  public char symFacingFG=' ',symFacingBG=' ';
  public ArrayList walkablesList = new ArrayList{'o','R','#'};
  public string directionFacing = "N/A";
  public char playerSymbol = '@';
  
  public void SpawnPlayers(Vector2Int des){
    LevelManager.LevelBackEnd.flipE(pos,true); //Remove Player
    pos = des; //Resigned Player Position
    LevelManager.LevelBackEnd.setE(pos,'@',true); //Add Player (w/Updated Position)
  }
  
  public void movePlayer() {
    Vector2Int des = GlobalMethods.findCords(pos,GameplayLoop.associatedKey); // des = Destination
    directionFacing = GlobalMethods.findDirectionFacing(pos, des);
    UnityEngine.Debug.Log("Facing ("+directionFacing+") MOVING PLAYER FROM ("+pos.x+","+pos.y+") to ("+des.x+","+des.y+")");
    
    #region Physical Collision
    
    if (isDesCharAllowedWalkable(des)) { //Will move player to a allowed walkable character
      pos = GlobalMethods.moveCharOnLevel(pos,des,playerSymbol);
    }

    if (isDesPellet(des)) {
      LevelManager.LevelBackEnd.setE(des,'#',false);
      //TODO: send  message that notifies observer that pellet was eaten
    }
    if (isDesPowerPellet(des)) {
      LevelManager.LevelBackEnd.setE(des,'#',false);
      
      //TODO IMPLIMENT : MAKE PLAYER INVINSABLE & KILL GHOST MODE
    }
    
    #endregion
  }

  #region Physical Collisions
  public bool isDesCharAllowedWalkable(Vector2Int des) { //Checks to see if can walk on the character at the destination
    return walkablesList.Contains(LevelManager.LevelBackEnd.getE(des, false));
  } // Checks if player can walk on destination  

  public bool isDesPellet(Vector2Int des)
  {
    return LevelManager.LevelBackEnd.getE(des,false).Equals('o');
  }
  public bool isDesPowerPellet(Vector2Int des)
  {
    return LevelManager.LevelBackEnd.getE(des,false).Equals('o');
  }
  //TODO Method: WHEN PLAYER HITS GHOST 

  #endregion
  
}
