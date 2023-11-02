using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkableArea : MonoBehaviour
{
    private void Start()
    {
        GameManager.INSTANCE.AddWalkableArea(this);
    }
}