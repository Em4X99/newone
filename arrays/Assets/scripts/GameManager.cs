using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables 
    private string stu1 = "Colin";
    //create a empty array of strings
    public string [] students = new string[7] {"Colin","Joseph","emmanuel","Lebron","justin","Bella","Evri"};
    private GameObject[] floor; 
    // Start is called before the first frame update
    //make a list of strngs
    public List<string> stuList = new List<string>();
    public List<GameObject> fllist;
    public Stack<string> stuStack = new Stack<string>();
    //Make a queue for students
    //queue is FIFO (First in First OUt)
    public Queue<string> stuQueue = new Queue<string>();
    void Start()
    {
        students[6] = stu1;
        stuList.Add("Joseph");
        //floor = GameObject.FindGameObjectsWithTag("floor");
        //remove absent student from the list (evri)
        stuList.Remove("Evri");

        //fllist.AddRange(floor);
        //add every student inside the list stulist to my stack
        foreach (string s in stuList)
        {
            stuStack.Push(s);   
        }
        Debug.Log(stuStack.Pop());
    }

    // Update is called once per frame
    void Update()
    {
        //prin the number of items in the list and array
        //LIST COUNT
        //Debug.Log(stuList.Count);
        //ARRAY LENGTH
        //Debug.Log(students.Length);
        //-1 for <= no -1 for <
        //for(int i=0;i<students.Length ; i++)
        {
            //Debug.Log(students[i]);
        }
    }
}
