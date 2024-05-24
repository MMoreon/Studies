import multiprocessing


# Функция для вычисления факториала числа
def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n - 1)


if __name__ == "__main__":
    # Число, для которого мы будем вычислять факториал
    number = 5

    # Количество процессов, которые будут использованы для параллельных вычислений
    num_processes = multiprocessing.cpu_count()

    # Создаем пул процессов
    pool = multiprocessing.Pool(processes=num_processes)

    # Вычисляем факториал параллельно
    result = pool.map(factorial, [number])

    # Закрываем пул процессов
    pool.close()
    pool.join()

    print(f"Факториал числа {number}: {result[0]}")
