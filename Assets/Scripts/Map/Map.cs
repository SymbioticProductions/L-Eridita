using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The job of this script is to spawn hexagonal tiles creating a basic map

public class Map : MonoBehaviour {

    public GameObject go_Hex_Prefab;

    //Size of the Map in terms of the number of hexagonal tiles and not world space
    int int_Map_Width = 100;
    int int_Map_Height = 100;

    //Offset of tiles to stagger them
    float fl_xOffset = 0.880f;
    float fl_zOffset = 0.760f;

    // Start is called before the first frame update
    void Start() {

        for (int x = 0; x < int_Map_Width; x++) {

            for (int y = 0; y < int_Map_Height; y++) {

                float fl_xPos = x * fl_xOffset;

                //Get Row
                if (y % 2 == 1) {
                    fl_xPos += fl_xOffset/2f;
                }

                GameObject go_Hex = (GameObject)Instantiate(go_Hex_Prefab, new Vector3( fl_xPos, 0, y * fl_zOffset), Quaternion.identity );      //Create an instance of the hex prefab with the following co-ordinates.
                                                                                                                                                //Treating it as a flat 2D plane using only X and Y, not Z

                go_Hex.name = "Hex_" + x + "_" + y;
                go_Hex.transform.SetParent(this.transform);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
