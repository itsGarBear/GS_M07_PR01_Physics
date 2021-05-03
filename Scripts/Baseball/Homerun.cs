using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Homerun : MonoBehaviour
{
    public Text text;
    public GameManager gm;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            text.text = "Homerun!";
            text.color = Color.white;
        }

        Destroy(this.gameObject);
        gm.Invoke("ResetScene", 1f);
    }

}
