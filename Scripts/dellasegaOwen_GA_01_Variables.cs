using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dellasegaOwen_GA_01_Variables : MonoBehaviour
{
    //Variables

    public string CurrentArea = "Firelink Shrine";
    public int Gold = 32085;
    public float Health = 87.3f;
    public bool PoisonStatus = false;
    public GameObject AsylumDemon;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"The player is currently in {CurrentArea}.");
        Debug.Log($"You currently have {Gold} pieces of gold.");
        Debug.Log($"You currently have {Health} HP.");
        Debug.Log($"Afflicted by poison: [{PoisonStatus}]");
        Debug.Log($"You encountered the boss {AsylumDemon}!");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World!");
        /*
        while (Health <= 100)
        {
            Health = Health + 1;
            if (Health > 100) { Health = 100; }
            Debug.Log($"Regenerating HP... currently at {Health} HP.");
        }
        */
    }
}
