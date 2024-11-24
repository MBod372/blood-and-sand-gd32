using StarterAssets;
using UnityEngine;
using UnityEngine.UI;

public class mouseSense : MonoBehaviour
{
    public GameObject Player;
    public Text choseSense;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.GetComponent<ThirdPersonController>().MouseSense = this.GetComponent<Slider>().value * 100;
        choseSense.GetComponent<Text>().text = (this.GetComponent<Slider>().value * 100).ToString();
    }

    
}
