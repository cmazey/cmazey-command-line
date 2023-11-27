#include "player.h"
#include "enemy.h"
#include <iostream>
#include <string>
#include <random>
#include <thread>
#include <chrono>
using namespace std;

void delayScroll(int delayInMs, int lineCount);
character* generateEnemy();
void encounterEnemy(character* player, character* enemy);
void fightDecisions(character* player);

int main() {
    srand(time(NULL));

    string playerName;
    string intro =
        "            _____         \n"
        "        __ /__    \\__    \n"
        "     _ /      \\    __\\  \n"
        "    /          \\__ /  \\ \n"
        "   |   O          O   |   \n"
        "   |      ______      /   \n"
        "    \\     \\____/     /  \n"
        "     \\______________/    \n\n"
        "--------------------------\n"
        "--- PET ROCK ADVENTURE ---\n"
        "--------------------------  ";

    cout << intro << endl;
    cout << "Name Your Rock: ";
    getline(cin, playerName);
    cout << endl << "That's a great name!" << endl;

    character* petRock = new player(playerName, "- Just a regular rock.");
    petRock->setStats(1);

    cout << petRock->name << " is a hearty rock with " << petRock->currentHealth << " health ";
    cout << "and a mighty attack that does " << petRock->damage << " damage!" << endl;

    cout << "It looks like " << playerName << " is ready for an adventure. ";
    cout << "Time to go out and explore..." << endl;

    this_thread::sleep_for(chrono::milliseconds(3000));
    delayScroll(100, 10);
    fightDecisions(petRock);
}

void delayScroll(int delayInMs, int lineCount) {
    for (int i = 0; i < lineCount; i++) {
        cout << endl;
        this_thread::sleep_for(chrono::milliseconds(delayInMs));
    }
}

character* generateEnemy() {
    string nameTemp;
    string descTemp;
    int levelTemp;

    random_device rd;
    int enemySelect = rd() % 3;
    switch (enemySelect) {
    case 0:
        nameTemp = "Umbrella";
        descTemp = "- A household object that keeps you dry in the rain.";
        levelTemp = 1;
        break;
    case 1:
        nameTemp = "Sunglasses";
        descTemp = "- Glasses tinted to protect your eyes from the light of the sun.";
        levelTemp = 2;
        break;
    case 2:
        nameTemp = "Parachute";
        descTemp = "- A device thats slows your descent to the ground.";
        levelTemp = 3;
    }

    character* e = new enemy(nameTemp, descTemp);
    e->setStats(levelTemp);
    return e;
}

void encounterEnemy(character* player, character* enemy) {
    while (player->isAlive() && enemy->isAlive()) {
        delayScroll(1500, 1);
        player->fight(enemy);
        if (enemy->currentHealth > 0) {
            delayScroll(1500, 1);
            enemy->fight(player);
        }
    }

    if (player->isAlive() == false) {
        cout << endl << "DEFEAT! Looks like " << enemy->name;
        cout << " knocked out " << player->name << "!" << endl;
        cout << "Hope you still had fun! ";
        cout << "You can always play again and try to survive longer." << endl;
    }
    else {
        cout << endl << "VICTORY! Looks like " << player->name;
        cout << " knocked out " << enemy->name << "!" << endl;
        cout << "Let's continue on with the adventure..." << endl;

        this_thread::sleep_for(chrono::milliseconds(2000));
        delayScroll(100, 10);
        fightDecisions(player);
    }
}

void fightDecisions(character* player) {
    character* anEnemy = generateEnemy();
    cout << "You encounter "; anEnemy->describe();
    cout << "The " << anEnemy->name << " appears to have ";
    cout << anEnemy->currentHealth << " health ";
    cout << "and an attack that does " << anEnemy->damage;
    cout << " damage. Ouch!" << endl;
    cout << "Remember: You have " << player->currentHealth;
    cout << " health remaining." << endl;

    int option = 0;
    cout << "QUICK! MAKE A DECISION..." << endl;
    cout << "1) Start Fight" << endl;
    cout << "2) Sneak Around" << endl;
    cout << "3) Retreat" << endl;
    cout << "ENTER DECISION: ";
    cin >> option;

    if (option == 1) {
        cout << "You decided to start a fight, so here it goes." << endl;
        encounterEnemy(player, anEnemy);
    }
    else if (option == 2) {
        cout << "You decided to try to sneak around without getting caught." << endl;
        delayScroll(1500, 1);

        random_device rd;
        int survive = rd() % 2;
        if (survive == 0) {
            cout << "LUCKY! You successfully snuck around the ";
            cout << anEnemy->name << " this time." << endl;
            cout << "Let's continue on with the adventure..." << endl;

            this_thread::sleep_for(chrono::milliseconds(2000));
            delayScroll(100, 10);
            fightDecisions(player);

        }
        else {
            cout << "AMBUSH! You were caught and knocked out by the ";
            cout << anEnemy->name << "!" << endl;
            cout << "Hope you still had fun! ";
            cout << "You can always play again and try to survive longer." << endl;
        }
    }
    else {
        cout << endl;
        cout << "GAME OVER! You surrendered and made everyone upset... " << endl;
        cout << "Hope you still had fun though! ";
        cout << "You can always play again and try to survive longer." << endl;
    }
}