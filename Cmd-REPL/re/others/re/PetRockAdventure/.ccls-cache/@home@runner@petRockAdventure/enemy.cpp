#include "enemy.h"
using namespace std;

void enemy::fight(character *other) {
  other->currentHealth -= damage;

  cout << name << " hit " << other->name;
  cout << " for " << damage << " damage!" << endl;
 
  cout << other->name << " has ";
  if (other->currentHealth < 0) {
    cout << "0";
  } else {
    cout << other->currentHealth;
  }
  cout << " out of " << other->totalHealth;
  cout << " health remaining." << endl;
}

void enemy::setStats(int level) { 
  damage = rand() % 10 + (10 * level - 5);
  currentHealth = totalHealth = rand() % 20 + (10 * level + 10);
} 

bool enemy::isAlive() {
  if (currentHealth > 0) {
    return true; 
  } else { 
    return false; 
  } 
}