using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableArea : MonoBehaviour
{
    private void Start()
    {
        GameManager.INSTANCE.AddPlaceableArea(this);
    }
}