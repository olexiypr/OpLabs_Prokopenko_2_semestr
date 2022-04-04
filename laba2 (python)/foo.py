import datetime
from Worker import Worker
import json

def writeFile(obj, nameFile):
    with open(nameFile, "w", encoding="utf-8") as fh:
        fh.write(json.dumps(obj))

def readFile (nameFile):
    obj = []
    with open(nameFile, encoding="utf-8") as fh:
        obj = json.loads(fh.read())
    for i in obj:
        print(i)
    return obj

def addOrNot ():
    i = int(input("For add object press 1: "))
    arr = []
    if i == 1:
        while True:
            a = input()
            if len(a) == 0:
                arr = [i.__dict__ for i in arr]
                return arr
            arr.append(Worker(a.split(' ')[0], a.split(' ')[1], a.split(' ')[2]))
            arr[0].Print()



def filterArr (arr, nameResFile):
    print("Працівники які пропрацювали не менше 5 років та народилися в цьому місяці: ")
    now = datetime.datetime.now()
    a = []
    for i in arr:
        if Worker.GetStaj(i) >= 5 and Worker.GetMonth(i) == now.month:
            Worker.Print(i)
        if Worker.GetStaj(i) >=10 and Worker.GetAge(i)-Worker.GetStaj(i) <= 25:
            a.append(i)
    a = [i.__dict__ for i in a]
    writeFile(a, nameResFile)
