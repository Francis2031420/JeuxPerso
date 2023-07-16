using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armspriteBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public string inputAxisName = "Horizontal";
    public int sortingOrderOffset = 0;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         float inputAxisValue = Input.GetAxisRaw(inputAxisName);
        int newSortingOrder = Mathf.RoundToInt(inputAxisValue);
        if (inputAxisValue != 0)
        spriteRenderer.sortingOrder = newSortingOrder; 
    }
}
