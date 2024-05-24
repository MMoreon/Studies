import multiprocessing
import random

# Функция для вычисления квадрата числа
def square(number):
    return number ** 2

if __name__ == "__main__":
    # Генерация
    numbers = [random.randint(1, 100) for _ in range(10)]
    print("Исходные числа:", numbers)

    # Создание пула процессов
    pool = multiprocessing.Pool()

    # Вычисление параллельно
    squared_results = pool.map(square, numbers)

    # Закрытие
    pool.close()
    pool.join()

    print("Квадраты чисел:", squared_results)
