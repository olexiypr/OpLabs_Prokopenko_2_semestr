//
// Created by alosh on 04.02.2022.
//
#include "header.h"
string countRepWord (string s) {  //кількість повторюваних слів
    string res;
    for (int i = 0; i < s.size(); ++i) {
        if (s[i]==' ' || s[i]==',' || s[i] == ';') {  //розбиттся рядка по пробілу або комі або крапці з комою
            int count=0;
            res = s.substr(0,i);  //видлення окремого слова
            int pos=i;
            while (s.find(res, pos)!=-1) {  //цикл який шукає кількість однакових слів
                count++;
                pos = s.find(res, pos + 1);
            }
            if (count !=0) {
                s= '{' + to_string(count) + '}'; //поверення готового рядка
                return s;
            } else {
                s.erase(0,i+1);
                i=0;
            }
        }
    }
}
string enterText() {
    string a = "text.txt";
    cout << "Input your text (press Ctrl + R to stop):\n";
    ofstream fout(a);
    string s;
    int count = 0;
    while(s.find(18) == string::npos) {
        getline(cin, s);
        if (count == 0 && s.find(18) == string::npos)
            fout << s;
        else if (s.find(18) == string::npos)
            fout << endl << s;
        count++;
    }
    fout.close();
    return a;
}
void changeText (string input, string out) {  //додавання зменених рядків до вихідного файлу
    ifstream inputText (input);   //відкриття для зчитування
    ofstream resultText (out);   //відкриття для запису
    if (!inputText.is_open() || !resultText.is_open()) {  //перевірка чи відкриті файли
        cout << "File is not open!" << endl;
        return;
    }
    string s;
    while (!inputText.eof()) {  //зчитування доки не закінчиться файл
        s="";
        getline(inputText, s);  //зчитування рядка файлу
        s=(countRepWord(s)+s + "\n");
        resultText << s;  //запис зміненого рядка в текстовий файл
    }
    inputText.close();
    resultText.close();
}
void outText (string a) {  //виведення вмісту текстового файлу на екран
    ifstream fr(a);
    string s;
    while (!fr.eof()) {
        s="";
        getline(fr, s);
        cout << s << endl;
    }
}
