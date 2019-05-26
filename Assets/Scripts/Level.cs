using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int blocks; // Serialized for debugging purposes

    // Cached reference
    SceneLoader sceneLoader;

    public void CountBlocks()
    {
        blocks++;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void BlockDestroyed()
    {
        blocks--;
        if(blocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
