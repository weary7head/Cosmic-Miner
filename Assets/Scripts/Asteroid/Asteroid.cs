using System;
using System.Text;
using UnityEngine;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    private const int MinimumMineralsCount = 100;
    private const int MaximumMineralsCount = 1000;
    private const int SymbolsCount = 8;
    private const int MinimumInclusiveSymbol = 65;
    private const int MaximumInclusiveSymbol = 90;

    private string _name;
    private int _mineralsCount;

    private void Awake()
    {
        _mineralsCount = GenerateMineralsCount();
        _name = GenerateName();
    }

    private string GenerateName()
    {
        StringBuilder nameBuilder = new StringBuilder();
        for (int i = 0; i < SymbolsCount; i++)
        {
            bool isLetter = Random.value > 0.5f ? true : false;
            
            if (isLetter == true)
            {
                char symbol = Convert.ToChar(Random.Range(MinimumInclusiveSymbol, MaximumInclusiveSymbol));
                nameBuilder.Append(symbol);
            }
            else
            {
                int figure = Random.Range(0, 9);
                nameBuilder.Append(figure);
            }
        }
        return nameBuilder.ToString();
    }

    private int GenerateMineralsCount()
    {
        return Random.Range(MinimumMineralsCount, MaximumMineralsCount);
    }
}
