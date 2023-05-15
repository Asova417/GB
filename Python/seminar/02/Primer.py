# n1 = int(input("Введите начало "))
# n2= int(input("Введите конец "))
# n3 = int(input("Введите шаг "))

# for i in range (n1, n2, n3):
#     print (i)

# i = 0
# while (i < 5):
#     print(i)
#     i+=1

# i = 0                   нифига не понятно но очень инересно
# while (i < 5):
#     n = int(input())
#     if n == 0:
#         break
#     i+=1
# else:
#     print("Конец")

# Вывод в столбик. Эта штуа распечатает слово в столбик по буквам, перебирая каждый элемент. end= "/n "
stroka = "qwerty"
for el in stroka:
    print(el)

# Ввод этого же слова только в СТРОЧКУ.
stroka = "qwerty"
for el in stroka:
    print(el, end= " ") # если между ковычками то буелет пробел между каждыми буквами