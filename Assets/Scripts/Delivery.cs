using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f;
        bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
void OnCollisionEnter2D(Collision2D other)
{
    Debug.Log("Ouch!");
}
void OnTriggerEnter2D (Collider2D other){
    //if the thing we triggered is package, then print "package picked up" on the console
    if (other.tag == "Package" && !hasPackage){
        Debug.Log("Package picked up!");
        hasPackage = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, destroyDelay);
    }
    if (other.tag == "Customer" && hasPackage){
        Debug.Log("Package delivered!");
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
    }
}
}
