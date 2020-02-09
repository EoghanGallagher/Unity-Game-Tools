using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameSceneUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene( )
    {
        Loader.Load( Loader.Scene.MainMenu );
    }
}
