using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshPro>();
    }

    public void SetName() 
    {
        text.text = PlayerPrefs.GetString("CharacterName");
    }
}
