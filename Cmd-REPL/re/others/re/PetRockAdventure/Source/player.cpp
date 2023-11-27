#include <iostream>
#include <string>
#include "player.h"
using namespace std;

void player::fight(character* other) {
    other->currentHealth -= damage;

    cout << name << " hit " << other->name;
    cout << " for " << damage << " damage!" << endl;

    cout << other->name << " has ";
    if (other->currentHealth < 0) {
        cout << "0";
    }
    else {
        cout << other->currentHealth;
    }
    cout << " out of " << other->totalHealth;
    cout << " health remaining." << endl;
}

void player::setStats(int level) {
    damage = (rand() % 15 + 10) * level;
    currentHealth = totalHealth = (rand() % 100 + 100) * level;
}

bool player::isAlive() {
    if (currentHealth > 0) {
        return true;
    }
    else {
        return false;
    }
}