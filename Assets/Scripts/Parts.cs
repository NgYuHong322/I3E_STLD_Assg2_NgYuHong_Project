using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *Author: Ng Yu Hong
 * Date: 18 / 6 / 24
 * Decription: parts
 */
public class Parts : Collectible
{
    public static int score = 1;

    public override int GetScoreValue()
    {
        return score;
    }
}
