using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Client : MonoBehaviour
{
    public int NumberOfWheels = 0;
    public bool Engine =  false;
    public int Passengers = 0;
    public bool Cargo = false;
    public TextMeshProUGUI stuff;
    public TextMeshProUGUI wheelCount;
    public TextMeshProUGUI passengernNumber;

    void Start()
    {
        //NumberOfWheels = Mathf.Max(NumberOfWheels, 1); //the max is the number the user inputs, if the user doesn't input, 1 wheel will be selected
        //Passengers = Mathf.Max(Passengers, 1);
        //Engine = Cargo;

        //VehicleRequirements requirements = new VehicleRequirements();
        //requirements.NumberOfWheels = NumberOfWheels;
        //requirements.Engine = Engine;
        //requirements.Passengers = Passengers;

        //IVehicle v = GetVehicle(requirements);
        //Debug.Log((v)); //set to string later???
    }

    void Update()
    {
        NumberOfWheels = Mathf.Max(NumberOfWheels, 1); //the max is the number the user inputs, if the user doesn't input, 1 wheel will be selected
        Passengers = Mathf.Max(Passengers, 1);

        VehicleRequirements requirements = new VehicleRequirements();
        requirements.NumberOfWheels = NumberOfWheels;
        requirements.Engine = Engine;
        requirements.Passengers = Passengers;
        requirements.Cargo = Cargo;
        //Engine = Cargo;

        IVehicle v = GetVehicle(requirements);
        Debug.Log((v)); //set to string later???
        stuff.text = v.ToString();
        wheelCount.text = "Wheels: " + NumberOfWheels.ToString();
        passengernNumber.text = "Passengers: " + Passengers.ToString();
    }

    public void PassengersButton()
    {
        Passengers++;
    }

    public void NumberOfWheelsButton()
    {
        NumberOfWheels++;
    }

    public void EngineButton()
    {
        if (Engine)
        {
            Engine = false;
        }
        else
            Engine = true;
    }

    public void CargoButton()
    {
        if (Cargo)
        {
            Cargo = false;
        }
        else
            Cargo = true;
    }

    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}
