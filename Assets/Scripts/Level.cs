using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purposes

    // Cached reference
    SceneLoader sceneLoader;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
