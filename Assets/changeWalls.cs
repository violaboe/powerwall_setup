using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class changeWalls : MonoBehaviour
{
    public Material neon;
    public roomManager roomManager;
    private List<GameObject> walls = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SceneLoaded()
    {
        walls = roomManager.GetAllWalls();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "WALL_FACE_EffectMesh")
        {
<<<<<<< Updated upstream
          //  other.gameObject.GetComponent<MeshRenderer>().material.color = ;
=======
            // Set the material to neon
            other.gameObject.GetComponent<MeshRenderer>().material = neon;

            // Get a random color and set its alpha to 0.2
            Color randomColor = Random.ColorHSV();
            randomColor.a = 0.6f;

            // Apply the color with the updated alpha to the material
            other.gameObject.GetComponent<MeshRenderer>().material.color = randomColor;
>>>>>>> Stashed changes
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
