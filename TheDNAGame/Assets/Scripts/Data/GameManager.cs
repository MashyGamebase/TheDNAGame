using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is where all the data lives
/// </summary>
namespace GameEssentials.GameManager
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameManager();

                return _instance;
            }
        }

        // Awake is called at the very first instance the game loads or this object gets enabled
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}