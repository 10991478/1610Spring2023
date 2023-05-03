using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*the ArrayObj object Scoreboard kept resetting between scenes because not all scenes referenced it
this script can be attached to an empty GameObject in any scene to make the scene reference Scoreboard, therefore preventing it from resetting between scenes*/
public class ReferToScoreboard : MonoBehaviour
{
    public ArrayObj scoreboard;
    void Start()
    {
        scoreboard.getInt(0); // briefly references the scoreboard so that its values don't get reset during the scene
    }
}
