#pragma once
#include <iostream>
#include <string>
using namespace std;

class character {
  public:
    string name; 
    string description; 
    int damage; 
    int totalHealth; 
    int currentHealth;

    character(); 
    character(string nameInput, string descriptionInput); 
    void describe();

    virtual void fight(character *other) = 0;
    virtual bool isAlive() = 0;
    virtual void setStats(int level) = 0; 
};

