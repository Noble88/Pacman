using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayLoop : MonoBehaviour
{
    
    public static string associatedKey="N/A", key="N/A";
    public static string gameState = "LEVEL";
    public static bool isNewKeyPressed = false;
    public static bool isGameControlable = false;
    
    
    void Start()
    {
        //Tile.Level1.BG = LevelManager.LevelFrontEnd;
        LevelManager.LevelFrontEnd = new TileGrid(new Vector2Int(20,20),1,"LEVEL",new Vector3(0,0,0));
        LevelManager.Player.SpawnPlayers(new Vector2Int(1,1));
        LevelManager.SwapLevel(1);
    }
    void Update()
    {
        keyboardInput();
        if (isNewKeyPressed){ //Checks to see if a new key is pressed 
            //Debug.Log("PRESSED: "+associatedKey);
            LevelManager.inputDirector(); 
            associatedKey="N/A"; key = "N/A"; isNewKeyPressed = false; //After "inputDirector", Allows for another key input (resets vars)
        }
        LevelManager.LevelFrontEnd.executeDisplayOfTileGrid();
        //CompleteTick();
    
    }

    public void keyboardInput()
    {
        if(Input.GetKeyDown(KeyCode.W)){keyPressed("UP");}
        if(Input.GetKeyDown(KeyCode.A)){keyPressed("LEFT");}
        if(Input.GetKeyDown(KeyCode.D)){keyPressed("RIGHT");}
        if(Input.GetKeyDown(KeyCode.S)){keyPressed("DOWN"); }
    }

    // Start is called before the first frame update

    
    private void keyPressed(string key) {
        associatedKey = key;
        isNewKeyPressed = true;
    }

}
