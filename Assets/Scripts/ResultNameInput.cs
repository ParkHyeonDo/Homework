using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultNameInput : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    // Start is called before the first frame update
    /*private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }*/

    // Update is called once per frame
    /*void Update()
    {
        if (playerName.Length >= 2 && playerName.Length <= 10  && Input.GetKeyDown(KeyCode.Return)) 
        {
            InputName();
        }
    }*/

    public void InputName() 
    {

        playerName = playerNameInput.text;
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            
        PlayerPrefs.SetString("CharacterName", playerName);
            gameObject.SetActive(false);
        }
    }
}
