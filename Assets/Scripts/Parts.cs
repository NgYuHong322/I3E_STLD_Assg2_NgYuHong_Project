using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : Collectible
{
    public static int score = 1;

    public override int GetScoreValue()
    {
        return score;
    }

}
