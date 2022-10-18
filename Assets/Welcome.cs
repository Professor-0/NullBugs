using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour
{
    Text txt;    
    string user;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    public void setUser(string s) {
        user = s;
    }

    public void displayText() {
        txt.text = "Welcome, " + user;
    }

}
