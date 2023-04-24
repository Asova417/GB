# Задача 2: Найдите сумму цифр трехзначного числа.

# *Пример:*
# 123 -> 6 (1 + 2 + 3)
# 100 -> 1 (1 + 0 + 0)

a = int (input('Введите число: '))
i=0
flag =True
while flag:
    if a > 10:
        i=int((a%10)+i)
        a=int(a/10)
    elif a<10:
        flag=False
        i=i+a
        print('Ответ:', i)
    elif a == 10:
        i=i+1
        flag=False
        print('Ответ:', i)