# a = 5
# b = 5.89
# c = 'hello'
# print (f"{a} - {b} - {c}")
# print ("{} - {} - {}".format(a, b, c))

# Пример вывода данных

# Ввод данных
# input () консоль предложит самостоятельно ввести данные

# a = input()  мы просто ввели свои данные
# print(a)

# print('Введите число: ')
# a = input ()
# print("Ваша цифра - " f"{a}")

# print('Введите первое число: ')
# a = input ()
# b = input('Введите второе число: ')  - форма записи

# Сумма двух чисел
# print('Введите первое число: ')
# a = input ()
# b = input('Введите второе число: ')
# print (a, '+', b, '=', a + b)
# Результат 34, скверно

# Приведение
# c = 5.89
# print(c)
# print(type(c))
# n = int(c)
# print(n)
# print(type(n))

# Сложение
# print('Введите первое число: ')
# a = int (input ())
# b = int (input('Введите второе число: '))
# print (a, '+', b, '=', a + b)

# Сложение, с настройкой для вывода знаков после запятой
# a = 5.4154545
# b = 6.4648648
# print (round(a*b, 3))

# inter = 2
# inter += 3 # inter = inter + 3
# inter -= 4 # inter = inter - 4
# inter *= 5 # inter = inter * 5
# inter /= 5 # inter = inter / 5
# inter //= 5 # inter = //5
# inter %= 5 # inter = inter % 5
# inter **= 5 # inter =inter ** 5 возвести в степень

#Логические операции

# a = 1 > 4
# print(a)
# Результат на консоле Folse

# a = 1 < 4 and 5 > 2      оператор and - объединяет условия
# print(a)
# Результат True

# a = 1 == 2
# print (a)
# Результат  Folse

# a = 1 !=2  ! - этот знак, это проверка на НЕ равенство "переменная А равна одному и НЕ РАВНА двум"
# print (a)
# Результат True

# a = 'qwe'
# b = 'qwe'
# print (a == b)
# Результат True

# a = 1 < 3 < 5 < 10
# print (a)
# Результат True

# Управляющие конструкции if, if-else

# and - обязательное соблюдение двух условий
# or - не обязательное соблюдение двух условий
# not 

# username = input ('Введите имя: ')
# if username == 'Маша':
#     print ('Урв, это же Маша!')
# elif username == 'Марина':
#     print ('Я так ждала Вас, Марина!')
# elif username == 'Ильнар':
#     print ('Ильнар - топ)')
# else:
#     print ('Принт, ', username)

# Цикл while
# i = 0
# while i < 5:
#     if i == 3:
#         break   # не желательно использовать, вместо него использовать метод ФЛАЖКА
#     i = i + 1
# else:
#     print ('Пожалуй')
#     print ('Хватит )')
# print(i)

# Использован метод ФЛАЖКА

# Задача. Пользователь вводит число, необходимо найти минимальный делитель данного числа

# print ('Введите число: ')
# n = int(input())
# flag = True
# i = 2
# while flag:
#     if n % i == 0: # если остаток при делении числа n на i равен 0
#         flag = False
#         print(i)
#     elif i > n // 2: # делить числа не может превышать введенное число, деленное на 2
#         print(n)
#         flag = False
#     i += 1

# Функция range()
# Выдает значения из диапазона с шагом 1
# Если указано только одно число -  от 0 до заданного числа
# Если нужен другой шан, третьим аргументом можно задать приращение

# r = range(5) # 0 1 2 3 4 5
# r = range(2, 5) # 2 3 4
# r = range(0, -5) # ----
# r = range(1, 10, 2) # 1 3 5 7 9 третье число дает шаг
# r = range(100, 0, -20) # 100 80 60 40 20 

#код пример
# r = range(100, 0, -20) # range(100, 0, -20)
# for i in r:
#     print(i) #100 80 60 40 20

# a = 'qwerty'
# print(a[2])  # Резульат будет "е", т.е. покажет что лежит в заданной ячейке массива

# a = 'qwerty'
# for i in a:
#     print (i) # значение i  поочередно принимает значение переменной a т.е. в консоле поочередно/построчно напечатается слово qwerty  только столбиком

# line = ""
# for i in range(5):  # цикл проработет 5 раз. в консоле будет 5 строчек из 5 плюсиков
#     line = ""
#     for j in range(5):
#         line += "+"
#     print (line)

# text = 'Съешь еще этих мягких французких булок'
# print(len(text))  #len функция поззволяет узнать размер строки + еще что-то. Лектор зажевал это. В коснпекте к лекциям я не нашла ничего.

#text = 'Съешь еще Этих мягких Французких БУЛОК'
# print('еще' in text)  # Результат True поскольку  слово 'еще' есть в переменной text  True
# print(text.lower()) # lower переводит все буквы в нижний регисстр т.е. делает их маленькими не заглавными              съешь еще этих мягких французких булок
# print(text.upper()) # upper переводит все буквы в верхний регистр т.е. делает их заглавными                            СЪЕШЬ ЕЩЕ ЭТИХ МЯГКИХ ФРАНЦУЗКИХ БУЛОК
#print(text.replace('еще','ЕЩЕ')) # меняет сочетания в первом указыввается что поменять, второе на какое изменить надо    Съешь ЕЩЕ Этих мягких Французких БУЛОК

# СРЕЗЫ
# Мы представляем строку в виде массива символов. Значит мы можем обращаться к элементам по индексам.
# Отрицательное число в индексе — счёт с конца строки!!!!!!!!!!!
# text = 'съешь ещё этих мягких французских булок'
# print(text[0]) # c
# print(text[1]) # ъ
# print(text[len(text)-1]) # к
# print(text[-1])  # еслинаписать отрицательный индекс, то индексация начнется с обратной стороны
# print(text[-5]) # б
# print(text[:]) # съешь ещё этих мягких французских булок - выведется все
# print(text[:2]) # съ - с 0 по 2 будет выводиться эти символы
# print(text[len(text)-2:]) #ок   последние 2 символа с конца
# print(text[20:])  #х французских булок  выводится с 20 символа(массива элемента) до самого конца
# print(text[2:9]) # ешь ещё  - вывод начинется со второго элемента и заканчивается 9
# print(text[6:-18]) # ещё этих мягких  - начинается и положительного 6 элемента и заканчивается отрицательным -18 (отрицательные элементы номер массива начинается с конца)
# bprint(text[0:len(text):6]) # сеикакл печать идет от 0 элемента с шагом 6, будет выводиться каждый шестой элемент. Этой щаписи так же эквивалента запись  print(text[::6])
# print(text[::6]) # сеикакл печать всего текста с шагом шесть
# text = text[2:9] + text[-5] + text[:2]  # результат: ешь ещёбсъ 
# print (text)
