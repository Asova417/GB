# Задача №11. Решение в группах
# Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите такое число n, что φ(n)=A. Если А не является числом Фибоначчи, выведите число -1.
# Input: 5
# Output: 6

a = int(input('Введите число:'))
if a == 0:
    print(1)
else:
    fib_prev, fib_next = 0, 1   # при помощи одной строчки положили значения в два элемента. fib_prev = 0 и  fib_next=1
    n = 2
    while fib_next <= a:
        if fib_next == a:
            print('Ответ:', n)
            break
        fib_prev, fib_next = fib_next, fib_prev + fib_next  # то же самое что и в 10 строчке fib_prev = fib_next, fib_next = fib_prev + fib_next немного более усложненный вариант, но так можно делать
        n += 1
    else:
        print('Ответ:',-1)