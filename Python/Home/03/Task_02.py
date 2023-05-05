# Задача 18: Требуется найти в массиве A[N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# Ввод: 5
# Ввод: 1 2 6 4 9
# Ввод: 8
# -> 9

import random

n = int(input("Введите длину списка "))
list_test = []
for i in range(n):
    list_test.append(random.randint(-n, n + n // 2))

print(list_test)

x = int(input("Введите число "))
val = list_test[0]
max_val = abs(x - list_test[0])
# for i in list_test:
#     t = abs(x - i)
#     if t < max_val:
#         max_val = t
#         val = i

set_test = set(list_test)
# for i in set_test:
#     t = abs(x - i)
#     if t < max_val:
#         max_val = t
#         val = i

[max_val := abs(x - i) if abs(x - i) < max_val]
print(max_val)
print(f"-> {val}")