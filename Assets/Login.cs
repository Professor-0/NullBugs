using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    string Username;
    
    Welcome welcome;

    void Start() {
        welcome = GameObject.Find("Welcome").GetComponent<Welcome>();
    }

    public void OnLogin() {
        var input = GameObject.Find("Username").GetComponent<InputField>();
        Username = input.text;
        welcome.setUser(Username);
    }
}
