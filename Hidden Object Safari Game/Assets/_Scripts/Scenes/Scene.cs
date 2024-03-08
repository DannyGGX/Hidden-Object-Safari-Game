using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Scene
{
    public Scenes SceneName;
    public int BuildIndex;
}

public enum Scenes
{
    MainMenu,

    Beginner_Dialogue,
    Beginner_Race,

    Checkpoint_Dialogue,
    Checkpoint_Race,

    Advanced_Dialogue,
    Advanced_Race,
}
