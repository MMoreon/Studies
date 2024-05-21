# Решение системы литнейных алгебраических уравнений с блочной двухдиагональной матрицей блочного порядка m и порядком блоков равным n


import numpy as np

def solve_block_diagonal_system(num, block, right_side_vector):
    """
        num (int): Количество блоков в матрице коэффициентов.
        block (int): Размер каждого блока.
        right_side_vector (numpy.ndarray): Вектор правых частей уравнений.
    
    Returns:
        numpy.ndarray: Решение системы уравнений.
    """
    coefficient_matrix = np.zeros((num * block, num * block))
    
    # Заполнение блочно-диагональной матрицы коэффициентов
    for i in range(num):
        coefficient_matrix[i*block:(i+1)*block, i*block:(i+1)*block] = np.eye(block) * (i + 1)
        if i < num - 1:
            coefficient_matrix[(i+1)*block:(i+2)*block, i*block:(i+1)*block] = np.eye(block)
    
    # Разбиение вектора правых частей на блоки
    right_side = [right_side_vector[i*block:(i+1)*block] for i in range(num)]
    
    # Решение системы для каждого блока
    solution = []
    for i in range(num):
        block_coefficient_matrix = coefficient_matrix[i*block:(i+1)*block, i*block:(i+1)*block]
        solution_block = np.linalg.solve(block_coefficient_matrix, right_side[i])
        solution.append(solution_block)
    
    # Объединение решений блоков в общее решение
    solution = np.hstack(solution)
    
    return solution


# Пример использования
num = 3
block = 2
right_side_vector = np.array([1, 2, 3, 4, 5, 6])

solution = solve_block_diagonal_system(num, block, right_side_vector)
print("Решение системы уравнений:")
print("x =", solution)
