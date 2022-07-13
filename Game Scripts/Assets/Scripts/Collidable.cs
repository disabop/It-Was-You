using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(BoxCollider2D))]
public class Collidable : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Start()
    {
        InteractionText.gameObject.SetActive(false);
        boxCollider = GetComponent<BoxCollider2D>();
        InteractionText.text = "Press 'E' to Interact";
    }

    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];
    public TextMeshProUGUI InteractionText;
    private Vector3 interactionPos = new Vector3(25, 0, 0);
    public bool interaction = false;

    // Update is called once per frame
    protected virtual void Update()
    {
        // Collision work
        boxCollider.OverlapCollider(filter, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
                
            }

            OnCollide(hits[i]);

            Debug.Log(hits[i].name);
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        interaction = true;
        Debug.Log("ITWORKED");
    }
}
