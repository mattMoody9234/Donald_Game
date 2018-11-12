using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum curPresident
{
    //Rifle with magic bullets
    JFK,

    //Jet that fires jet fuel
    GeorgeWBush,

    //Desk that shoots Monica Lewinsky's head
    BillClinton
};

public enum curEnemy
{
    Bernie,
    //Is actually the Zodiac Killer
    TedCruiz,

    Hillary
};
//use this for keeping track of stuff between scenes
public class StaticTracker {


    public static curPresident curHelpingPres = curPresident.JFK;

    public static curEnemy curEnemyPolitician = curEnemy.Bernie;
}
