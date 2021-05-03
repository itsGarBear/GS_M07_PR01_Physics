using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Fielder[] fielders;
    public Text text;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScene();
        }

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TargetBall(GameObject ball)
    {
        
        foreach (Fielder f in fielders)
        {
            
            //f.myTarget = ball;
        }
    }
}
