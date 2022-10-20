using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    public float speed = 20f;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
 

    Rigidbody m_Rigidbody;
    Vector3 m_Movement;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        
        winText.enabled = false;

        
    {
        GameObject scoreGo = GameObject.Find("CountText");
        scoreGT = scoreGo.GetComponent<Text>();

        count = int.Parse(scoreGT.text);
        //count += 1;
        scoreGT.text = count.ToString();
    }
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            count = count + 5 ;
             scoreGT.text = count.ToString();
            //SetCountText();
        }
        if (other.gameObject.CompareTag)

    
    }
}
    

    
