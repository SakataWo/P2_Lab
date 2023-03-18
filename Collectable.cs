using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class Collectable
{
    public string nameCollectable;
    public int score;
    public int restoreHP;

    public Collectable(string name, int scorevalue, int restoreHPvalue)
    {
        this.nameCollectable = name;
        this.score = scorevalue;
        this.restoreHP = restoreHPvalue;
    }
}
