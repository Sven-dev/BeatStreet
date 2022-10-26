using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField] private UnityStringEvent OnMovePerformed;
    [Space]
    [SerializeField] private float Tickrate = 0.034f; //in ticks
    [SerializeField] private List<Move> Moves;

    private List<Input> SentInputs = new List<Input>();
    private List<Jar> InputJars = new List<Jar>();

    private void Start()
    {
        StartCoroutine(_Tickrate());
    }

    public void AddInput(Input input)
    {
        SentInputs.Add(input);
    }

    private IEnumerator _Tickrate()
    {
        while (true)
        {
            //Construct an input with the inputs sent since the last tick
            Jar inputJar = new Jar();
            inputJar.Inputs.AddRange(SentInputs);
            InputJars.Insert(0, inputJar);

            //Remove old jars
            SentInputs.Clear();
            if (InputJars.Count >= 1 / Tickrate)
            {
                InputJars.RemoveAt(InputJars.Count -1);
            }

            //Print inputs if one is being made
            if (inputJar.Inputs.Count > 0)
            {
                string temp = "new input: ";
                foreach (Input input in inputJar.Inputs)
                {
                    temp += input.ToString() + ", ";
                }
                //print(temp);
            }

            //Check if a move is being performed
            CheckForMove();

            yield return new WaitForSeconds(Tickrate);
        }
    }

    private void CheckForMove()
    {
        //Get inputs from the latest tick
        List<Input> inputs = InputJars[0].Inputs;

        //Check if a punch or a kick was pressed
        if (inputs.Contains(Input.Punch) || inputs.Contains(Input.Kick))
        {
            foreach (Move move in Moves)
            {
                print("New move_____________________________________________________");

                //Combine all of the inputs within tickrate
                List<Input> jarInputs = new List<Input>();
                for (int i = 0; i < move.timeframe; i++)
                {
                    //Filter out all of the inputs that aren't relevant to the move
                    foreach (Input input in InputJars[i].Inputs)
                    {
                        if (move.Inputs.Contains(input))
                        {
                            jarInputs.Add(input);
                            print(input.ToString());
                        }                       
                    }
                }

                print("_______________________________________________");

                //Reverse the list to put the inputs in chronological order
                jarInputs.Reverse();

                if (jarInputs.Count >= move.Inputs.Count)
                {
                    //Check if all the inputs were done in the correct order
                    int correctInputs = 0;
                    for (int i = 0; i < jarInputs.Count; i++)
                    {
                        if (jarInputs[i] == move.Inputs[correctInputs])
                        {
                            correctInputs++;

                            //If all of the inputs have been performed
                            if (correctInputs == move.Inputs.Count)
                            {
                                //Do move
                                OnMovePerformed?.Invoke(move.Name);
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}

[System.Serializable]
public class Move
{
    public string Name;
    public int timeframe; //In frames
    //public bool CancelsIntoKick;
    //public bool CancelsIntoPunch;
    public List<Input> Inputs;
}

public class Jar
{
    public List<Input> Inputs = new List<Input>();
}