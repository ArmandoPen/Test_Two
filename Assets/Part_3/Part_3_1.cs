using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Area(10, 3);       //Result should be 30
        //Area();            //Result should be 1
        //Area(2.5f, 3.7f);  //Result should be 9.25f
        Area(10, 3);
        print(Area(10, 3));
        Area();
        print(Area());
        Area(2.5f, 3.7f);
        print(Area(2.5f, 3.7f));
    }

    //Create a function called Area where you pass in two integer values and
    //return the Area value (1pt)

    //Add default values to the Area such that width = 1 and length = 1 (1pt)

    //Overload the function by creating another Area function but this one takes in
    //float values and returns a float  (1pt) 
    int Area(int length, int width)
    {
        return length * width;
    }
    int Area()
    {
        return 1 * 1;
    }
    float Area(float length, float width)
    {
        return length * width;
    }
}
