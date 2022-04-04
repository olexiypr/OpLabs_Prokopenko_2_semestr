import datetime
class Worker:
    def __init__(self, pib, birth, dateStartWork):
        self.pib = pib
        self.birth = birth
        self.dateStartWork = dateStartWork
    def __int__(self):
        self.pib = 1
        self.birth = 1
        self.dateStartWork = 1
    def GetStaj(self):
        now = datetime.datetime.now()
        month = int(self.dateStartWork.split('.')[1])
        year = int(self.dateStartWork.split('.')[2])
        day = int(self.dateStartWork.split('.')[0])
        if month > now.month:
            return now.year - 1 - year
        elif month == now.month:
            if day>now.day:
                return now.year - year - 1
        return now.year - year

    def Print(self):
        print(self.pib + " " + self.birth + " " + self.dateStartWork)

    def GetMonth(self):
        month = int(self.birth.split('.')[1])
        return month
    def GetAge(self):
        now = datetime.datetime.now()
        month = int(self.dateStartWork.split('.')[1])
        year = int(self.dateStartWork.split('.')[2])
        day = int(self.dateStartWork.split('.')[0])
        if month < now.month:
            return now.year - 1 - year
        elif month == now.month and day<now.day:
            return now.year - year - 1
        return now.year - year