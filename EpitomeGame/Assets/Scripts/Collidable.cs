﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        // collision work
        boxCollider.OverlapCollider(filter, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            Debug.Log(hits[i].name);

            // the array is not cleaned up, so we do it ourself
            hits[i] = null;
        }
    }

    protected virtual void Oncollide(Collider2D collider)
    {
        Debug.Log(collider.name);
    }
}