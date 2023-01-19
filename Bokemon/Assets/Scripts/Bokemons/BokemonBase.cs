using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// scriptable objects are data containers for the game
// helps to create a new scriptable object in the project window
[CreateAssetMenu(fileName = "Bokemon", menuName = "Bokemon/Create new bokemon")]
public class BokemonBase : ScriptableObject {
    // use this variable outside this class, but bad practice to make it public
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] BokemonType type1;
    [SerializeField] BokemonType type2;

    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int specialAttack;
    [SerializeField] int specialDefense;
    [SerializeField] int speed;

    // list of learnable moves by bokemon and their level
    [SerializeField] List<LearnableMove> learnableMoves;

    // getter properties in C#, use capital letter for the first letter to get the value of the variable
    public string Name { get => name; }
    public string Description { get => description; }
    public Sprite FrontSprite { get => frontSprite; }
    public Sprite BackSprite { get => backSprite; }
    public BokemonType Type1 { get => type1; }
    public BokemonType Type2 { get => type2; }
    public int MaxHP { get => maxHP; }
    public int Attack { get => attack; }
    public int Defense { get => defense; }
    public int SpecialAttack { get => specialAttack; }
    public int SpecialDefense { get => specialDefense; }
    public int Speed { get => speed; }
    public List<LearnableMove> LearnableMoves { get => learnableMoves; }
}

// learnable move class for a bokemon
// display in inspector
[System.Serializable]
public class LearnableMove {
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base { get => moveBase; }
    public int Level { get => level; }
}

public enum BokemonType {
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
    Dark,
    Steel
}