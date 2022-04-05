import functions

nameInputFile = "text.txt"
nameResultFile = "text1.txt"
open(nameInputFile, "w")
open(nameResultFile, "w")
arrOfWorkers = [  #список працівників
    ("Володимирович 14.07.1990 02.05.2013"),
    ("Петрович 11.04.1987 14.08.2009"),
    ("Васильович 15.04.1960 21.11.1990"),
    ("Романов 27.02.1983 11.11.2011")
]
print(arrOfWorkers)
functions.writeInFile(nameInputFile, arrOfWorkers)
print("-----Вміст файла:-----")
functions.readFile(nameInputFile)
functions.abbInFile(nameInputFile)
print("-----Вміст файла після додавання:-----")
arrOfWorkers = functions.readFile(nameInputFile)
functions.filterArr(arrOfWorkers, nameResultFile)
print("-----Працівники які працюють з 25 років не менше 10 років:-----")
functions.readFile(nameResultFile)