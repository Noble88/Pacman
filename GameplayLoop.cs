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
        LevelManager.GoToLevel(1);
        LevelManager.Player.SpawnPlayers(new Vector2Int(6,8));
        associatedKey = "N/A";
        LevelManager.enemies[0]= new Enemy()
        LevelManager.LevelFrontEnd.updateWholeGrid(); //Update Grid after all changes are mode

    }

    private float tickInterval = 1f/20f; 
    private float timeSinceLastTick = 0.0f;


    float totalNumberOfTicks=20;
    float currentTick;
    
    void Update()
    {
        timeSinceLastTick += Time.deltaTime;
        keyboardInput();
        // Check if it's time for a tick.
        if (timeSinceLastTick >= tickInterval) {
            if (currentTick%2==0) { LevelManager.inputDirector(); } //Tick for player (moves every other tick)
            LevelManager.
            LevelManager.LevelFrontEnd.executeDisplayOfTileGrid(); //Update Grid after all changes are mode

            #region Tick EndBehvaior 
            timeSinceLastTick = 0.0f;
            if (totalNumberOfTicks == currentTick) { currentTick = 0; }//resets ticks if at 20 ticks (20ticks = 1 seocnd)
            currentTick++; // Updates tick
            #endregion
        }
        
        
    }


    public void keyboardInput() {
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
