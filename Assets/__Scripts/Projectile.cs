using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour {

    private BoundsCheck bndCheck;
    private Renderer rend;

    [Header("Set Dynamically")]
    public Rigidbody rigid;
    [SerializeField]
    private WeaponType _type;
   
    public Text scoreGT;

    private Rigidbody rb;
    private int count;


    void Start()
    {
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        scoreGT = scoreGo.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // This public property masks the field _type and takes action when it is set
    public WeaponType type
    {
        get
        {
            return (_type);
        }
        set
        {
            SetType(value);
        }
    }
    private void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
        rend = GetComponent<Renderer>();
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (bndCheck.offUp)
        {
            Destroy(gameObject);
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
        if (other.gameObject.CompareTag("Enemy1"))
        {
            other.gameObject.SetActive(false);
            count = count + 10 ;
             scoreGT.text = count.ToString();
        }
        if (other.gameObject.CompareTag("Enemy2"))
        {
            other.gameObject.SetActive(false);
            count = count + 15 ;
             scoreGT.text = count.ToString();
        }
        if (other.gameObject.CompareTag("Enemy3"))
        {
           other.gameObject.SetActive(false);
            count = count + 20 ;
             scoreGT.text = count.ToString(); 
        }
        if (other.gameObject.CompareTag("Enemy4"))
        {
          other.gameObject.SetActive(false);
            count = count + 25 ;
             scoreGT.text = count.ToString();   
        }

    }



    ///<summary>
    /// Sets the _type private field and colors this projectile to match the
    /// WeaponDefinition.
    /// </summary>
    /// <param name="eType">The WeaponType to use.</param>
    public void SetType(WeaponType eType)
    {
        // Set the _type
        _type = eType;
        WeaponDefinition def = Main.GetWeaponDefinition(_type);
        rend.material.color = def.projectileColor;
    }
}
