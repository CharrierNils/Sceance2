using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SPHERE : MonoBehaviour
{

    public int Nombre_spheres = 4;
    public float Rayon = 4f;
   // public Color Couleur ;

    
    public GameObject Sphere;
    private GameObject[] Det;




    void Start()
    {

        //On a essayé de changer la couleur du cube mais par manque de temps on a pas pu le faire fonctionner

        //Instantiate(Sphere, new Vector3(0, 0, 0), Quaternion.identity);
        //var SphereRenderer = Sphere.GetComponent<Renderer>();
        //SphereRenderer.material.SetColor("_Color", Color.red);
    }

    void Update()
    {
        DestroySphere();  //On detruit la sphere à chaque Update sinon on aura une infinité de boule et Unity plantera
       


        //boucle for qui crée les spheres:
            for (var i = 0; i < Nombre_spheres; i++)
            {
            var Angle = (Mathf.PI * 2 * i) / Nombre_spheres;
            var Position = new Vector3(Mathf.Cos(Angle), 0, Mathf.Sin(Angle)) * Rayon;
            Instantiate(Sphere, Position, Quaternion.identity);
             
            }





        //fonction pour detruire les spheres

        void DestroySphere()
        {
            Det = GameObject.FindGameObjectsWithTag("Sphere");
            foreach (GameObject obj in Det)
            {
                Destroy(obj);
            }
        }  
        
    }
}

