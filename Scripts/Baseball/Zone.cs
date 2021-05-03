using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zone : MonoBehaviour
{
    public Text text;
    public GameManager gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            text.text = "Out!";
            text.color = Color.red;

            Destroy(other.gameObject);
            gm.Invoke("ResetScene", 1f);
        }
 
    }

}
