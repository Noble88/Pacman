using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreMadeLevels : MonoBehaviour
{
  public static Level Level1 = new Level(
    "Level 1",
    new char[,]
    {
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','R','o',' ',' ','o','R','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o','o','o','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o',' ',' ','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','R','o',' ',' ','o','R','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
    },
    new char[,]
    {
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','R','o',' ',' ','o','R','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o','o','o','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o',' ',' ','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','R','o',' ',' ','o','R','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o',' ','o',' ',' ','o',' ','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ','o','o','o','o','o','o','o','o',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
      {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',},
    }
  );

}
