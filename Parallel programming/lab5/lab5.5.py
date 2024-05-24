import multiprocessing


# Функция для поиска выхода из лабиринта
def find_exit(maze, start_row, end_row, exit_found):
    # Проход в глубину для поиска выхода из лабиринта
    def dfs(row, col):
        if row < 0 or row >= len(maze) or col < 0 or col >= len(maze[0]) or maze[row][
            col] == 0 or exit_found.value == 1:
            return
        if row == end_row and maze[row][col] == 1:
            exit_found.value = 1  # Выход найден
            return
        maze[row][col] = 0  # Помечаем текущую ячейку как посещенную
        dfs(row + 1, col)  # Вниз
        dfs(row - 1, col)  # Вверх
        dfs(row, col + 1)  # Вправо
        dfs(row, col - 1)  # Влево
    
    # Начинаем поиск выхода из лабиринта
    dfs(start_row, 0)


if __name__ == "__main__":
    # Пример лабиринта (0 - стена, 1 - проход)
    maze = [
        [0, 0, 1, 0, 0],
        [0, 0, 1, 0, 0],
        [0, 0, 1, 1, 1],
        [1, 1, 1, 0, 0],
        [1, 0, 0, 0, 0]
    ]

    # Создаем объект для обмена информацией между процессами
    exit_found = multiprocessing.Value('i', 0)

    # Количество строк в лабиринте
    num_rows = len(maze)

    # Создаем процессы для каждой строки лабиринта
    processes = []
    for row in range(num_rows):
        process = multiprocessing.Process(target=find_exit, args=(maze, row, num_rows - 1, exit_found))
        processes.append(process)

    # Запускаем все процессы
    for process in processes:
        process.start()

    # Ждем завершения всех процессов
    for process in processes:
        process.join()

    if exit_found.value == 1:
        print("Выход из лабиринта найден.")
    else:
        print("Выход из лабиринта не найден.")
