using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tabtale.TTPlugins;

namespace RedPanda
{
    public class ClikSDK : MonoBehaviour
    {
        private void Awake()
        {
            // Initialize CLIK Plugin
            TTPCore.Setup();
            // Your code here
            Debug.Log("hi");
        }
        
        
    }
}
