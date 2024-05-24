import multiprocessing

# Функция для нахождения максимального значения в части списка
def find_max_partial(data_chunk):
    return max(data_chunk)

# Функция для вычисления количества максимальных значений в списке
def count_max_values(data):
    num_processes = multiprocessing.cpu_count()
    chunk_size = len(data) // num_processes

    # Разделение данных на части
    data_chunks = [data[i:i+chunk_size] for i in range(0, len(data), chunk_size)]

    # Создание пула процессов
    pool = multiprocessing.Pool(processes=num_processes)

    # Поиск максимального значения в каждой части списка
    max_values = pool.map(find_max_partial, data_chunks)

    # Закрытие пула процессов
    pool.close()
    pool.join()

    # Находим максимальное значение из всех найденных максимумов
    global_max = max(max_values)

    # Считаем количество максимальных значений в исходном списке
    count = max_values.count(global_max)

    return count

if __name__ == "__main__":
    # Исходный список данных
    data = [1, 5, 3, 7, 5, 9, 5, 5, 9, 8, 5, 9]

    # Вычисляем количество максимальных значений
    max_count = count_max_values(data)

    print("Количество максимальных значений:", max_count)
