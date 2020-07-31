﻿using UnityEngine;
using UnityEngine.SceneManagement;
 
 public class Restart : MonoBehaviour
 {
   void Update ()
   {
     if (Input.GetKeyDown(KeyCode.O))
     {
       SceneManager.LoadScene( SceneManager.GetActiveScene().name );
     }
   }
 }