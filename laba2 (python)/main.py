import functions

nameInputFile = "text.txt"
nameResultFile = "text1.txt"
open(nameInputFile, "w") #створення або очищення файлів
open(nameResultFile, "w") #створення або очищення файлів
arrOfWorkers = [  #список працівників
    ("Володимирович 14.07.1990 02.05.2013"),
    ("Петрович 11.04.1987 14.08.2009"),
    ("Васильович 15.04.1960 21.11.1990"),
    ("Романов 27.02.1983 11.11.2011")
]
print(arrOfWorkers)
functions.writeInFile(nameInputFile, arrOfWorkers) #запис списку працівників в файл
print("-----Вміст файла:-----")
functions.readFile(nameInputFile) #виведення вмісту файла
functions.abbInFile(nameInputFile) #додавання в файл
print("-----Вміст файла після додавання:-----")
arrOfWorkers = functions.readFile(nameInputFile) #зчитування файлу після додавання
functions.filterArr(arrOfWorkers, nameResultFile) #фільтрування працівників (виведення або запис в результуючий файл)
print("-----Працівники які працюють з 25 років не менше 10 років:-----")
functions.readFile(nameResultFile) #зчитування результуючого файлу