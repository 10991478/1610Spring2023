using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*the ArrayObj object Scoreboard kept resetting between scenes because not all scenes referenced it
this script can be attached to an empty GameObject in any scene to make the scene reference Scoreboard, therefor preventing it from resetting between scenes*/
public class ReferToScoreboard : MonoBehaviour
{
    public ArrayObj scoreboard;
    void Start()
    {
        scoreboard.getInt(0); 
    }
}
