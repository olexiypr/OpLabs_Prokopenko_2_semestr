def out (nameInputText, nameResultText):
    a=open(nameInputText) #відкриття файлів на зчитування
    b=open(nameResultText)
    print("Input text: ")
    print(a.read()) #виведення ввмісту файлів
    print("Result text: ")
    print(b.read())
    a.close()
    b.close()

def changeString (stroka):
    stroka=stroka.replace(';',',') #заміна всих крапок з комою на кому
    stroka=stroka.replace(',','') #видалення всих ком
    stroka=stroka.split() #розбиття рядка на слова по пробілам
    count=0
    for i in range(len(stroka)): #цикл для порівняння кожного слова рядка і підрахунку однакових слів
        for j in range(len(stroka)):
            if j<=i:
                continue
            if stroka[i]==stroka[j]:
                count+=1
        if count!=0:
            return str(count+1)

def changeFile (stroka): #запис зміненого рядка в результуючий файл
    resultText.write(stroka)

def enterText (name):
    f = open(name, 'w')  # відкриття файлу для запису
    text = " "
    c = 0
    while (text):
        text = input() #введення рядка для запису в файл
        if c == 0:
            f.write(text)
        else:
            f.write('\n' + text)  #запис рядків в файл
        c += 1
    f.close()

def addText(): #додавання тексту в кінець файлу
    print("Input your text:")
    a = 'text.txt'
    f = open(a, 'a')  #відкриття файлу для дозапису в кінець
    text = " "
    c = 0
    while(text):
        text=input()
        if c == 0: f.write(text)
        else: f.write("\n"+text) #запис в файл
        c+=1
    f.close() #закриття файлу

print("To complete the input, press Enter")
print("Enter text: ")
nameInputText = "text.txt"
nameResultText = "text1.txt"
resultText = open(nameResultText, 'w') #відкриття вихідного файлу на запис
enterText(nameInputText)
n = int(input("If you want to add text press 1"))
if n == 1:  #дозаписувати/не дозаписувати
    addText()
inputText = open(nameInputText) #відкриття вхідного файлу на зчитування
for stroka in inputText: #цикл для порядкового зчитування тексту
    stroka= '{' + changeString(stroka) + '}' + stroka #зміна рядка
    changeFile(stroka) #запис рядка в результуючий файл
inputText.close()
resultText.close()
out(nameInputText, nameResultText) #виведення вмісту файлів на екран

