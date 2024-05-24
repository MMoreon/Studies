import threading
import time
import random

def option_one():
    print("Вы выбрали путь через лес.")
    time.sleep(2)
    print("На вашем пути встретилась волшебница.")
    time.sleep(2)
    print("Она предлагает вам выбрать дар:")
    print("1. Силу")
    print("2. Здоровье")
    print("3. Ловкость")
    gift_choice = input("Введите номер выбранного дара: ")
    if gift_choice == '1':
        print("Вы получили дар силы!")
    elif gift_choice == '2':
        print("Вы получили дар здоровья!")
    elif gift_choice == '3':
        print("Вы получили дар ловкости!")
    else:
        print("Неверный выбор. Волшебница исчезла.")
    time.sleep(2)
    print("Вы нашли сундук с сокровищами!")

def option_two():
    print("Вы выбрали путь через пустыню.")
    time.sleep(2)
    print("На вашем пути появилось чудовище!")
    time.sleep(2)
    print("Вы можете попытаться:")
    print("1. Сразиться с чудовищем")
    print("2. Убежать от чудовища")
    fight_choice = input("Введите номер выбранного действия: ")
    if fight_choice == '1':
        if random.randint(1, 10) > 5:
            print("Вы одержали победу над чудовищем!")
        else:
            print("Чудовище победило вас. Игра окончена.")
            return
    elif fight_choice == '2':
        print("Вы успешно убежали от чудовища.")
    else:
        print("Неверный выбор. Чудовище атакует вас.")
        print("Игра окончена.")
        return
    time.sleep(2)
    print("Вы попали в древний храм и нашли артефакт!")

print("Добро пожаловать в квест!")
print("Вы стоите перед двумя путями.")
print("Выберите один из них:")
print("1. Путь через лес")
print("2. Путь через пустыню")

choice = input()

if choice == '1':
    thread1 = threading.Thread(target=option_one)
    thread1.start()
elif choice == '2':
    thread2 = threading.Thread(target=option_two)
    thread2.start()
else:
    print("Неверный выбор. Игра завершена.")
