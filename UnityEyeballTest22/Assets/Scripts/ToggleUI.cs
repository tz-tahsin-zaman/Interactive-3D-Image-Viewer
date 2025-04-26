using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //This should be here

public class ToggleUI : MonoBehaviour
{
    Toggle toggleButton; 
    public Transform eyePart; 
    bool boolCheck;

    void Start(){
        boolCheck = true;
        toggleButton = GetComponent<Toggle>();
        toggleButton.onValueChanged.AddListener(delegate{
            ToggleAction(toggleButton);});
    }

    void ToggleAction(Toggle change){

        if(boolCheck) boolCheck = false; 
        else boolCheck = true; 
        eyePart.gameObject.SetActive(boolCheck);
    }
}
