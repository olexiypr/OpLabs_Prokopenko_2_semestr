from BankAccount import *


currents = [CurrentAccount(["mono", 1, 1000]), CurrentAccount(["privat", 2, 12000])]  #список розрахункових рахунків
deposits = [DepositAccount(["mono", 3, 2000, 5, "15.02.2022", 12]), DepositAccount(["privat", 4, 5000, 5, "19.05.2021", 6])]  #список депозитів
if input("For add account press 1: ") == '1':
    n = (int)(input("Enter the number of bank accounts: "))
    init_arrays(n, currents, deposits)  #додавання нових акаунтів
    n += len(currents)-n
else:
    n = len(currents)

check_deposits(n, currents, deposits)  #функція для симуляції поведінки акаунтів
print_accounts(n, currents, deposits)  #виведення інформації про рахунки