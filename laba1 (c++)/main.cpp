//#include <SFML/Graphics.hpp>
#include <iostream>
#include <string>
#include "header.h"
using namespace std;
int main()
{
    string nameInputText = "text.txt"; //ім'я вхідного файлу
    string nameOutputText = "text1.txt"; //ім'я вихідного файлу
    string fin = enterText();
    system("CLS");
    enterText ();
    changeText(nameInputText, nameOutputText);  //зміна тексту
    cout << "Input text: " << endl;
    outText(nameInputText); //виведення тесту
    cout << "Result text: " << endl;
    outText(nameOutputText); //виведення тексту
}
