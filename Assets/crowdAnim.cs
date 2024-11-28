using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class crowdAnim : MonoBehaviour
{
    public List<GameObject> crowd = new List<GameObject>();
    public int currentPerson;
    public int chosenAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < crowd.Count; i++)
        {

            if (crowd[i].GetComponent<Animator>() != null)
            {
                int animtrigger = Random.Range(0, 3);
               
                crowd[i].GetComponent<Animator>().SetInteger("chosenAnim", animtrigger);              
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
      
        
        
        /*
        if(currentPerson < crowd.Count)
        {
            chooseAnim();
        }
        else if(currentPerson > crowd.Count)
        {
            Destroy(this);
        }*/
    }

    public void chooseAnim()
    {
        crowd.ElementAt(currentPerson).GetComponent<Animator>().SetInteger(chosenAnim, Random.Range(0, 2));
        currentPerson += 1;
        Debug.Log(chosenAnim);
    }
}
