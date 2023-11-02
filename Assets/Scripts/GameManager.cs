using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> snails;
    [SerializeField] private List<GameObject> walkableAreas;
    [SerializeField] private List<GameObject> placeableAreas;
    [SerializeField] private GameState gameState;

    public static GameManager INSTANCE;

    // Start is called before the first frame update
    void Start()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWalkableArea(WalkableArea newArea)
    {
        walkableAreas.Add(newArea.gameObject);
    }

    public void AddPlaceableArea(PlaceableArea newArea)
    {
        placeableAreas.Add(newArea.gameObject);
    }

    enum GameState
    {
        PLAYING,
        BUILDING,
        PAUSED,
        GAME_OVER
    }
}
