# n1 = int(input("Введите начало "))
# n2= int(input("Введите конец "))
# n3 = int(input("Введите шаг "))

# for i in range (n1, n2, n3):  1 вариант  это одна запись одного и того же действия 
#     print (i)

# while (i<5):  2 вариант
#     print(i)
#     i+=1

i=0
while (i < 5):
    n = int(input())
    if n == 0:
        break
    i+=1
else:
    print("Конец")