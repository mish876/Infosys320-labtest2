using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Pathfinding.Serialization.JsonFx; //make sure you include this using

public class Sketch : MonoBehaviour
{
    public GameObject myPrefab;
    // Put your URL here
    public string _WebsiteURL = "http://infosys320labtest01.azurewebsites.net/tables/TreeSurvey?zumo-api-version=2.0.0";

    public static string text;
    public static string text1;
    public static string text2;
    public static string text3;
    public static string text4;
    public static string text5;
    public static string text6;
    public static string text7;
    public static string text8;
    public static string text9;
    public static string text10;
    public static string text11;
    public static string text12;
    public static List<GameObject> objects = new List<GameObject>();
    public static List<string> textList;

    void Start()
    {
        //Reguest.GET can be called passing in your ODATA url as a string in the form:
        //The response produce is a JSON string
        string jsonResponse = Request.GET(_WebsiteURL);

        //Just in case something went wrong with the request we check the reponse and exit if there is no response.
        if (string.IsNullOrEmpty(jsonResponse))
        {
            return;
        }

        //We can now deserialize into an array of objects - in this case the class we created. The deserializer is smart enough to instantiate all the classes and populate the variables based on column name.
        TreeSurvey[] birds = JsonReader.Deserialize<TreeSurvey[]>(jsonResponse);

        int totalCubes = birds.Length;

        int i = 0;

        float x = 0;
        float y = 0;
        float z = 0;


        //We can now loop through the array of objects and access each object individually
        foreach (TreeSurvey bird in birds)
        {
            //Example of how to use the object
            Debug.Log("This object name is: " + birds[i].Location);
            float perc = i / (float)totalCubes;

            i++;

            x = float.Parse(birds[i].X);

            y = float.Parse(birds[i].Y);

            z = float.Parse(birds[i].Z) - 5;

            GameObject newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<myCubeScript>().setSize(0.3f);
            objects.Add(newCube);

            
            newCube.GetComponentInChildren<TextMesh>().text = birds[i].Location;
            
            if (i == 1)
            {
                text1= "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 2)
            {
                text2 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 3)
            {
                text3 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 4)
            {
                text4 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 5)
            {
                text5 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 6)
            {
                text6 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 7)
            {
                text7 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 8)
            {
                text8 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 9)
            {
                text9 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 10)
            {
                text10 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 11)
            {
                text11 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }

            if (i == 12)
            {
                text12 = "X=" + x + " " + "Y=" + y + " " + "Z=" + z;
            }


        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                objects[0].GetComponentInChildren<TextMesh>().text = text1;
                objects[0].GetComponent<Renderer>().material.color = Color.red;
                objects[1].GetComponentInChildren<TextMesh>().text = text2;
                objects[1].GetComponent<Renderer>().material.color = Color.blue;
                objects[2].GetComponentInChildren<TextMesh>().text = text3;
                objects[2].GetComponent<Renderer>().material.color = Color.green;
                objects[3].GetComponentInChildren<TextMesh>().text = text4;
                objects[3].GetComponent<Renderer>().material.color = Color.red;
                objects[4].GetComponentInChildren<TextMesh>().text = text5;
                objects[4].GetComponent<Renderer>().material.color = Color.blue;
                objects[5].GetComponentInChildren<TextMesh>().text = text6;
                objects[5].GetComponent<Renderer>().material.color = Color.green;
                objects[6].GetComponentInChildren<TextMesh>().text = text7;
                objects[6].GetComponent<Renderer>().material.color = Color.red;
                objects[7].GetComponentInChildren<TextMesh>().text = text8;
                objects[7].GetComponent<Renderer>().material.color = Color.blue;
                objects[8].GetComponentInChildren<TextMesh>().text = text9;
                objects[8].GetComponent<Renderer>().material.color = Color.green;
                objects[9].GetComponentInChildren<TextMesh>().text = text10;
                objects[9].GetComponent<Renderer>().material.color = Color.red;
                objects[10].GetComponentInChildren<TextMesh>().text = text11;
                objects[10].GetComponent<Renderer>().material.color = Color.blue;
                objects[11].GetComponentInChildren<TextMesh>().text = text12;
                objects[11].GetComponent<Renderer>().material.color = Color.green;



            }
        }


    }

}