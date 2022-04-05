import os.path
import datetime
def writeInFile (name, arr):
    if os.path.exists(name):  #перевірка чи існує такий файл
        writer = open(name, 'ab') #відкриття файлу на дозапис байтів
        for i in arr:
            byteObj = (i+'\n').encode() #перетворення рядка на байти
            writer.write(byteObj)

def abbInFile (name):
    a = int(input("-----Для додавання працівника натисніть 1: "))
    if a == 1:
        writer = open(name, 'ab') #відкриття файлу на дозапис байтів
        while True:
            i = input()
            if len(i) == 0:
                return
            else:
                byteObj = (i + '\n').encode() #перетворення рядка на байти
                writer.write(byteObj)
                # writeInFile(name, i)

def readFile (name):
    if os.path.exists(name): #перевірка чи існує такий файл
        arr = []
        reader = open(name, 'rb') #відкриття файлу на зчитування байтів
        for i in reader:
            worker = i.decode() #перетворення байтів на рядок
            worker = worker[:-1]
            arr.append(worker)
            print(worker)
        return arr

def filterArr (arr, name):
    print("-----Працівники які пропрацювали не менше 5 років та народилися в цьому місяці:----- ")
    a = []
    now = datetime.datetime.now() #отримання поточної дати та часу
    for i in arr:
        if GetStaj(i.split(' ')[2]) >= 5 and GetMonth(i.split(' ')[1]) == now.month:
            print(i)
        if GetStaj(i.split(' ')[2]) >= 10 and (GetAge(i.split(' ')[1]) - GetStaj(i.split(' ')[2])) <= 25:
            a.append(i)
    writeInFile(name, a)


def GetStaj(dateStartWork): #отримання стажу
    now = datetime.datetime.now()
    month = int(dateStartWork.split('.')[1])
    year = int(dateStartWork.split('.')[2])
    day = int(dateStartWork.split('.')[0])
    if month > now.month:
        return now.year - 1 - year
    elif month == now.month:
        if day>now.day:
            return now.year - year - 1
    return now.year - year

def GetMonth(birth): #отримання місяця народження
    month = int(birth.split('.')[1])
    return month

def GetAge(birth): #отримання віку
    now = datetime.datetime.now()
    month = int(birth.split('.')[1])
    year = int(birth.split('.')[2])
    day = int(birth.split('.')[0])
    if month < now.month:
        return now.year - 1 - year
    elif month == now.month and day<now.day:
        return now.year - year - 1
    return now.year - year















