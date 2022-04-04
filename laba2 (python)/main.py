import json
import datetime
from Worker import Worker
import foo


nameInputFile = "text.json"
open(nameInputFile, "w")
nameResultFile = "text1.json"
arrOfWorkers = [
    Worker("Володимирович", "14.07.1990", "02.05.2013"),
    Worker("Петрович", "11.04.1987", "14.08.2009"),
    Worker("Васильович", "15.03.1960", "21.11.1990"),
    Worker("Романов", "27.02.1983", "11.11.2011")
]
arrOfWorkers = [i.__dict__ for i in arrOfWorkers]
print("Вміст файла: ")
foo.writeFile(arrOfWorkers, nameInputFile)
deserializedArr = foo.readFile(nameInputFile)
deserializedArr = [Worker(i["pib"], i["birth"], i["dateStartWork"]) for i in deserializedArr]

temp = foo.addOrNot()
if temp != None:
    for i in temp:
        arrOfWorkers.append(i)

print("Вміст файла після додавання: ")
foo.writeFile(arrOfWorkers, nameInputFile)
deserializedArr = foo.readFile(nameInputFile)
deserializedArr = [Worker(i["pib"], i["birth"], i["dateStartWork"]) for i in deserializedArr]
foo.filterArr(deserializedArr, nameResultFile)
print("Вмыст другого файла: ")
deserializedArr = foo.readFile(nameResultFile)
print("Працівники які працюють з 25 років не менше 10 років:")
deserializedArr = [Worker(i["pib"], i["birth"], i["dateStartWork"]) for i in deserializedArr]
for i in deserializedArr:
    i.Print()
