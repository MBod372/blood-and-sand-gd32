using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class playerMeleemanager : MonoBehaviour
{
    public AnimatorController swordSlash;
    public int chosenSlash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chooseSlash()
    {
        chosenSlash = Random.Range(0, slashAnims.Count); // remember to add all new animations into the list so they can be selected
        AnimatorController.
        
    }

}
