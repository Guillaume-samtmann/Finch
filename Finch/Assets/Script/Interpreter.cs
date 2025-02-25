using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();
    public List<string> Interpret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        if (args[0] == "help")
        {
            //Return some info
            response.Add("If you want to use the terminal, type \"boop\" ");
            response.Add("This is the second line that we are returning");

            return response;
        }
        else
        {
            response.Add("Command not recognized.");

            return response;
        }
    }
}
