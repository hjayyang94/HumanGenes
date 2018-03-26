using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour {

    //Genes for color that will be passed later
    public float r;
    public float g;
    public float b;
    public float size;

    bool dead = false;
    public float timeToDead = 0;

    SpriteRenderer sRenderer;
    Collider2D sCollider;

    private void OnMouseDown()
    {
        dead = true;
        timeToDead = PopulationManager.elapsed;
        Debug.Log("Dead At: " + timeToDead);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }
    private void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        
        
        sRenderer.transform.localScale+= new Vector3(size, size, 0);



    }
}
