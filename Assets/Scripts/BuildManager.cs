using System;
using UnityEngine;

#if UNITY_STANDALONE
    public class BuildManager : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKeyDown("escape")) { Application.Quit(); }
        }
    }

#endif