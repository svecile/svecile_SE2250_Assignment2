using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    public GameObject cubePrefab;
    private GameObject gObj;
    private List<GameObject> pickUpList;
    private int numCubes = 0;

    // Start is called before the first frame update
    void Start()
    {
        pickUpList = new List<GameObject>();
        Color c1 = new Color(Random.value, Random.value, Random.value);
        Color c2 = new Color(Random.value, Random.value, Random.value);
        Color c3 = new Color(Random.value, Random.value, Random.value);

        for (int i = 0; i < 3; i++)
        {
            gObj = Instantiate<GameObject>(cubePrefab);
            Properties property = gObj.GetComponent<Properties>();
            property.PointValue = 1;
            gObj.name = "Cube" + numCubes;
            gObj.tag = "Pick Up";
            gObj.GetComponent<Renderer>().material.color = c1;
            pickUpList.Add(gObj);
            numCubes++;
        }
        for (int i = 0; i < 3; i++)
        {
            gObj = Instantiate<GameObject>(cubePrefab);
            Properties property = gObj.GetComponent<Properties>();
            property.PointValue = 2;
            gObj.name = "Cube" + numCubes;
            gObj.tag = "Pick Up";
            gObj.GetComponent<Renderer>().material.color = c2;
            pickUpList.Add(gObj);
            numCubes++;
        }
        for (int i = 0; i < 2; i++)
        {
            gObj = Instantiate<GameObject>(cubePrefab);
            Properties property = gObj.GetComponent<Properties>();
            property.PointValue = 3;
            gObj.name = "Cube" + numCubes;
            gObj.tag = "Pick Up";
            gObj.GetComponent<Renderer>().material.color = c3;
            pickUpList.Add(gObj);
            numCubes++;
        }
        pickUpList[0].transform.position = new Vector3(8, 2, 0);
        pickUpList[1].transform.position = new Vector3(-8, 2, 0);
        pickUpList[2].transform.position = new Vector3(0, 2, 8);
        pickUpList[3].transform.position = new Vector3(0, 2, -8);
        pickUpList[4].transform.position = new Vector3(6, 2, 6);
        pickUpList[5].transform.position = new Vector3(-6, 2, 6);
        pickUpList[6].transform.position = new Vector3(-6, 2, -6);
        pickUpList[7].transform.position = new Vector3(6, 2, -6);
        
    }

}
