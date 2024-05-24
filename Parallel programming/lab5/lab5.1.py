import multiprocessing

def fibonacci(n):
    if n <= 1:
        return n
    else:
        return fibonacci(n - 1) + fibonacci(n - 2)


if __name__ == "__main__":
    # Число, для которого мы будем вычислять число Фибоначчи
    number = 25

    # Количество процессов, которые будут использованы для параллельных вычислений
    num_processes = multiprocessing.cpu_count()

    # Создаем пул процессов
    pool = multiprocessing.Pool(processes=num_processes)

    # Вычисляем число Фибоначчи параллельно
    result = pool.map(fibonacci, [number])

    # Закрываем пул процессов
    pool.close()
    pool.join()

    print(f"Число Фибоначчи для {number}: {result[0]}")
