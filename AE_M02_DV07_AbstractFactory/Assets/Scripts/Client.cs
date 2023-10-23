using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Client : MonoBehaviour
{
    //public int NumberOfWheels = 0;
    //public bool Engine =  false;
    //public int Passengers = 0;
    //public bool Cargo = false;

    public int NumberOfLegs;
    public bool FarmAnimal;
    public bool WildAnimal;
    public bool Pet;
    public bool HasNoFur;
    public int HasFur;

    public Image image;

    public TextMeshProUGUI typeOfAnimalText;
    public TextMeshProUGUI legNumberText;

    public TextMeshProUGUI isFarmAnimalText;


    //public TextMeshProUGUI stuff;
    //public TextMeshProUGUI wheelCount;
    //public TextMeshProUGUI passengernNumber;

    //public TextMeshProUGUI legNumberDropdown;

    void Start()
    {
        NumberOfLegs = Mathf.Max(NumberOfLegs);

        AnimalRequirements requirements = new AnimalRequirements();
        requirements.FarmAnimal = FarmAnimal;
        requirements.WildAnimal = WildAnimal;
        requirements.Pet = Pet;
        requirements.NumberOfLegs = NumberOfLegs;
        requirements.HasFur = HasFur;
        //requirements.Cargo = Cargo;
        //Engine = Cargo;

        IAnimal v = GetAnimal(requirements);
        Debug.Log((v)); //set to string later???

        typeOfAnimalText.text = v.ToString();
        legNumberText.text = "Legs: " + NumberOfLegs.ToString();
        isFarmAnimalText.text = "Is Farm Animal? " + FarmAnimal.ToString();
        image.sprite = v.AddImage();
    }

    void Update()
    {

    }

    public void Spawn()
    {
        //NumberOfWheels = Mathf.Max(NumberOfWheels, 1); //the max is the number the user inputs, if the user doesn't input, 1 wheel will be selected

        AnimalRequirements requirements = new AnimalRequirements();
        requirements.FarmAnimal = FarmAnimal;
        requirements.WildAnimal = WildAnimal;
        requirements.Pet = Pet;
        requirements.NumberOfLegs = NumberOfLegs;
        requirements.HasFur = HasFur;
        //requirements.Cargo = Cargo;
        //Engine = Cargo;

        IAnimal v = GetAnimal(requirements);
        Debug.Log((v)); //set to string later???

        typeOfAnimalText.text = v.ToString();
        legNumberText.text = "Legs: " + NumberOfLegs.ToString();
        isFarmAnimalText.text = "Is Farm Animal? " + FarmAnimal.ToString();
        image.sprite = v.AddImage();

        //:)

        //passengernNumber.text = "Passengers: " + Passengers.ToString();
    }

    //DROPDOWN MENU
     public void NumberOfLegsData(int legNumber)
    {
        if (legNumber == 0)
        {
            Debug.Log(legNumber);
            NumberOfLegs = 0;
        }

        if (legNumber == 1) //why isn't the int changind
        {
            Debug.Log(legNumber + "HELLOOOOO");
            NumberOfLegs = 2;
        }

        if (legNumber == 2)
        {
            NumberOfLegs = 4;
        }
    }

    public void AnimalTypeData(int animalType)
    {
        if (animalType == 0)
        {
            HasFur = 0;
        }

        if (animalType == 1)
        {
            HasFur = 1;
        }

        if(animalType == 2)
        {
            HasFur = 2;
        }
    }

    public void FarmAnimalData(int FANum)
    {
        if(FANum == 0)
        {
            FarmAnimal = false;
            Pet = false;
        }
        if (FANum == 1)
        {
            FarmAnimal = true;
            Pet = false;
        }

        if (FANum == 2)
        {
            Pet = true;
            FarmAnimal = true;
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private static IAnimal GetAnimal(AnimalRequirements requirements)
    {
        AnimalFactory factory = new AnimalFactory(requirements);
        return factory.Create();
    }
}
