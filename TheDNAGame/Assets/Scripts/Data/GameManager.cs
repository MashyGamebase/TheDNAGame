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
        public static GameManager Instance;

        /// <summary>
        /// Dictates which scene to load
        /// </summary>
        public int sceneToLoad;


        // Define any variables that we can store and track here
        // We can store them locally in a persistent drive somewhere in the device
        public int playerScore;
        public int playerCoins;
        public int totalGameTimeSession; // Might be unnecessary

        // Awake is called at the very first instance the game loads or this object gets enabled
        private void Awake()
        {
            if(Instance == null)
                Instance = this;


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


public class PlayerData
{
    public int playerScore;
    public int playerCoins;
    public int totalGameTimeSession;
}