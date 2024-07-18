using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
   //light on off script
    
        public bool lighton = false;

        void Start()
        {
            this.GetComponent<Light>().enabled = false;
        }

       
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                lighton = !lighton; 
                this.GetComponent<Light>().enabled = lighton; 
            }
        }
    }




